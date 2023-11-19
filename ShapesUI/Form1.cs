using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ShapesLib;

namespace ShapesUI
{
    public partial class Form1 : Form
    {
        private static List<Shape> shapesList = new List<Shape>();

        private static Dictionary<string, ShapeFactory> shapeFactories = new Dictionary<string, ShapeFactory>
        {
            { "triangle", new ShapeFactory() },
            { "circle", new ShapeFactory() },
            { "ellipse", new ShapeFactory() },
            { "square", new ShapeFactory() },
            { "rhombus", new ShapeFactory() },
            { "rectangle", new ShapeFactory() },
            { "equilateraltriangle", new ShapeFactory() }
        };


        public Form1()
        {
            InitializeComponent();
        }

        private void GetDemoObject_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files | *.txt";
            openFileDialog.Title = "Оберіть файл з параметрами геометричних фігур";
            openFileDialog.InitialDirectory = @"C:\Users\Админ\source\repos\ShapesEducationProject\data";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                ReadShapesFromFile(fileName);
                DisplayShapesInfo();
            }
        }

        private void ReadShapesFromFile(string fileName)
        {
            shapesList.Clear();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(' ');

                        if (parts.Length > 0)
                        {
                            string shapeType = parts[0].Trim().ToLower();

                            if (shapeFactories.TryGetValue(shapeType, out var factory))
                            {
                                Shape shape = factory.CreateShape(shapeType, parts.Skip(1).ToArray());
                                shapesList.Add(shape);
                            }
                            else
                            {
                                MessageBox.Show($"Не відомий тип фігури: {shapeType}");
                            }
                        }
                    }
                }

                DisplayShapesInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при читанні файлу: {ex.Message}");
            }
        }

        private void DisplayShapesInfo()
        {
            textAllocator.Clear();

            if (shapesList.Count == 0)
            {
                textAllocator.AppendText("Немає інформації про фігури." + Environment.NewLine);
                return;
            }

            foreach (var shape in shapesList)
            {
                string info = $"Type: {shape.Name}, Area: {shape.GetArea():F2}; Perimeter: {shape.GetPerimeter():F2}";
                textAllocator.AppendText(info + Environment.NewLine);
            }
        }
    }
}


