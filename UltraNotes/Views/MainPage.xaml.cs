using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using UltraNotes.ViewModels;

namespace UltraNotes.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private void BoldButton_Click(object sender, RoutedEventArgs e)
    {
        ITextSelection selectedText = editor.Document.Selection;
        if (selectedText != null)
        {
            ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
            charFormatting.Bold = FormatEffect.Toggle;
            selectedText.CharacterFormat = charFormatting;
        }
    }

    private void ItalicButton_Click(object sender, RoutedEventArgs e)
    {
        ITextSelection selectedText = editor.Document.Selection;
        if (selectedText != null)
        {
            ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
            charFormatting.Italic = FormatEffect.Toggle;
            selectedText.CharacterFormat = charFormatting;
        }
    }

    private void UnderlineButton_Click(object sender, RoutedEventArgs e)
    {
        ITextSelection selectedText = editor.Document.Selection;
        if (selectedText != null)
        {
            ITextCharacterFormat charFormatting = selectedText.CharacterFormat;
            if (charFormatting.Underline == UnderlineType.None)
            {
                charFormatting.Underline = UnderlineType.Single;
            }
            else
            {
                charFormatting.Underline = UnderlineType.None;
            }
            selectedText.CharacterFormat = charFormatting;
        }
    }
}
