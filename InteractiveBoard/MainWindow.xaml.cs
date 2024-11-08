using System.Windows;
using System.Windows.Controls;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;

namespace InteractiveBoard
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			SetDefaultDrawingAttributes();
		}

		private void SetDefaultDrawingAttributes()
		{
			drawingCanvas.EditingMode = InkCanvasEditingMode.Ink;
			drawingCanvas.DefaultDrawingAttributes.Color = Colors.Black;
			drawingCanvas.DefaultDrawingAttributes.Width = 2;
			drawingCanvas.DefaultDrawingAttributes.Height = 2;
		}

		// Кнопка для рисования (ручка)
		private void PenButton_Click(object sender, RoutedEventArgs e)
		{
			drawingCanvas.EditingMode = InkCanvasEditingMode.Ink;
		}

		// Кнопка для стирания
		private void EraserButton_Click(object sender, RoutedEventArgs e)
		{
			drawingCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
		}

		// Кнопка для выбора цвета
		private void ColorButton_Click(object sender, RoutedEventArgs e)
		{

		}

		// Кнопка для очистки холста
		private void ClearButton_Click(object sender, RoutedEventArgs e)
		{
			drawingCanvas.Strokes.Clear();
		}
	}
}