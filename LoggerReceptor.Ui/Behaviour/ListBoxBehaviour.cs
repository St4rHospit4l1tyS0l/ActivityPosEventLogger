using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace LoggerReceptor.Ui.Behaviour
{
    public static class ListBoxBehaviour
    {
        public static readonly DependencyProperty AutoCopyProperty = DependencyProperty.RegisterAttached("AutoCopy",
            typeof(bool), typeof(ListBoxBehaviour), new UIPropertyMetadata(AutoCopyChanged));

        public static bool GetAutoCopy(DependencyObject obj)
        {
            return (bool)obj.GetValue(AutoCopyProperty);
        }

        public static void SetAutoCopy(DependencyObject obj, bool value)
        {
            obj.SetValue(AutoCopyProperty, value);
        }

        private static void AutoCopyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            var listBox = obj as ListBox;
            if (listBox != null)
            {
                if ((bool)e.NewValue)
                {
                    ExecutedRoutedEventHandler handler =
                        (sender, arg) =>
                        {
                            if (listBox.SelectedItem != null)
                            {
                                //Copy what ever your want here
                                Clipboard.SetDataObject(listBox.SelectedItem.ToString());
                            }
                        };

                    var command = new RoutedCommand("Copy", typeof(ListBox));
                    command.InputGestures.Add(new KeyGesture(Key.C, ModifierKeys.Control, "Copy"));
                    listBox.CommandBindings.Add(new CommandBinding(command, handler));
                }
            }
        }
    }
}
