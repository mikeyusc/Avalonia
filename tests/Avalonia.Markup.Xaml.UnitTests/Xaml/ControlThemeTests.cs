using Avalonia.Controls;
using Avalonia.Controls.Presenters;
using Avalonia.Data;
using Avalonia.Markup.Xaml.Templates;
using Avalonia.Media;
using Avalonia.Styling;
using Avalonia.UnitTests;
using Avalonia.VisualTree;
using Xunit;

namespace Avalonia.Markup.Xaml.UnitTests.Xaml
{
    public class ControlThemeTests : XamlTestBase
    {
        [Fact]
        public void ControlTheme_Can_Be_StaticResource()
        {
            using (UnitTestApplication.Start(TestServices.StyledWindow))
            {
                var xaml = $@"
<Window xmlns='https://github.com/avaloniaui'
        xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
        xmlns:u='using:Avalonia.Markup.Xaml.UnitTests.Xaml'>
    <Window.Resources>
        {ControlThemeXaml}
    </Window.Resources>

    <u:TestTemplatedControl Theme='{{StaticResource MyTheme}}'/>
</Window>";

                var window = (Window)AvaloniaRuntimeXamlLoader.Load(xaml);
                var button = Assert.IsType<TestTemplatedControl>(window.Content);

                window.Show();

                Assert.NotNull(button.Template);

                var child = Assert.Single(button.GetVisualChildren());
                var border = Assert.IsType<Border>(child);

                Assert.Equal(Brushes.Red, border.Background);
            }
        }

        [Fact]
        public void ControlTheme_Can_Be_DynamicResource()
        {
            using (UnitTestApplication.Start(TestServices.StyledWindow))
            {
                var xaml = $@"
<Window xmlns='https://github.com/avaloniaui'
        xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
        xmlns:u='using:Avalonia.Markup.Xaml.UnitTests.Xaml'>
    <Window.Resources>
        {ControlThemeXaml}
    </Window.Resources>

    <u:TestTemplatedControl Theme='{{DynamicResource MyTheme}}'/>
</Window>";

                var window = (Window)AvaloniaRuntimeXamlLoader.Load(xaml);
                var button = Assert.IsType<TestTemplatedControl>(window.Content);

                window.Show();

                Assert.NotNull(button.Template);

                var child = Assert.Single(button.GetVisualChildren());
                var border = Assert.IsType<Border>(child);

                Assert.Equal(Brushes.Red, border.Background);
            }
        }

        [Fact]
        public void ControlTheme_Can_Be_Set_In_Style()
        {
            using (UnitTestApplication.Start(TestServices.StyledWindow))
            {
                var xaml = $@"
<Window xmlns='https://github.com/avaloniaui'
        xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
        xmlns:u='using:Avalonia.Markup.Xaml.UnitTests.Xaml'>
    <Window.Resources>
        {ControlThemeXaml}
    </Window.Resources>

    <Window.Styles>
        <Style Selector='u|TestTemplatedControl'>
            <Setter Property='Theme' Value='{{StaticResource MyTheme}}'/>
        </Style>
    </Window.Styles>

    <u:TestTemplatedControl/>
</Window>";

                var window = (Window)AvaloniaRuntimeXamlLoader.Load(xaml);
                var button = Assert.IsType<TestTemplatedControl>(window.Content);

                window.Show();

                Assert.NotNull(button.Template);

                var child = Assert.Single(button.GetVisualChildren());
                var border = Assert.IsType<Border>(child);

                Assert.Equal(Brushes.Red, border.Background);
            }
        }
        
        [Fact]
        public void Correctly_Resolve_TemplateBinding_In_Nested_Style()
        {
            using (UnitTestApplication.Start(TestServices.StyledWindow))
            {
                var xaml = $@"
<ControlTheme xmlns='https://github.com/avaloniaui'
              xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
              xmlns:u='using:Avalonia.Markup.Xaml.UnitTests.Xaml'
              TargetType='u:TestTemplatedControl'>
    <Setter Property='Template'>
        <ControlTemplate>
            <Border/>
        </ControlTemplate>
    </Setter>
    <Style Selector='^ /template/ Border'>
        <Setter Property='Tag' Value='{{TemplateBinding TestData}}'/>
    </Style>
</ControlTheme>";

                var theme = (ControlTheme)AvaloniaRuntimeXamlLoader.Load(xaml);
                var style = Assert.IsType<Style>(Assert.Single(theme.Children));
                var setter = Assert.IsType<Setter>(Assert.Single(style.Setters));
                
                Assert.Equal(TestTemplatedControl.TestDataProperty, (setter.Value as TemplateBinding)?.Property);
            }
        }

        private const string ControlThemeXaml = @"
<ControlTheme x:Key='MyTheme' TargetType='u:TestTemplatedControl'>
    <Setter Property='Template'>
        <ControlTemplate>
            <Border/>
        </ControlTemplate>
    </Setter>
    <Style Selector='^ /template/ Border'>
        <Setter Property='Background' Value='Red'/>
    </Style>
</ControlTheme>";
    }
}
