//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     GenAPI Version: 7.0.8.6004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Avalonia.Data
{
    [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("BindingExpression and ReflectionBinding heavily use reflection. Consider using CompiledBindings instead.")]
    public partial class Binding : Avalonia.Data.BindingBase
    {
        public Binding() { }
        public Binding(string path, Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.Default) { }
        public string? ElementName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public string Path { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.Data.RelativeSource? RelativeSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public object? Source { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.Func<string?, string, System.Type>? TypeResolver { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
    }
    public abstract partial class BindingBase : Avalonia.Data.IBinding
    {
        public BindingBase() { }
        public BindingBase(Avalonia.Data.BindingMode mode = Avalonia.Data.BindingMode.Default) { }
        public Avalonia.Data.Converters.IValueConverter? Converter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public object? ConverterParameter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.WeakReference? DefaultAnchor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public object? FallbackValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.Data.BindingMode Mode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.WeakReference<Avalonia.Controls.INameScope?>? NameScope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.Data.BindingPriority Priority { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public string? StringFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public object? TargetNullValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        private protected abstract Avalonia.Data.Core.ExpressionObserver CreateExpressionObserver(Avalonia.AvaloniaObject target, Avalonia.AvaloniaProperty? targetProperty, object? anchor, bool enableDataValidation);
        protected System.IObservable<object?> GetParentDataContext(Avalonia.AvaloniaObject target) { throw null; }
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessageAttribute("Trimming", "IL2026", Justification="Convertion methods might be removed by the linker. We don't have a reliable way to prevent it, except converting everything in compile time when possible.")]
        public Avalonia.Data.InstancedBinding? Initiate(Avalonia.AvaloniaObject target, Avalonia.AvaloniaProperty? targetProperty, object? anchor = null, bool enableDataValidation = false) { throw null; }
    }
    public partial class MultiBinding : Avalonia.Data.IBinding
    {
        public MultiBinding() { }
        [Avalonia.Data.AssignBindingAttribute]
        [Avalonia.Metadata.ContentAttribute]
        public System.Collections.Generic.IList<Avalonia.Data.IBinding> Bindings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.Data.Converters.IMultiValueConverter? Converter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public object? ConverterParameter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public object FallbackValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.Data.BindingMode Mode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.Data.BindingPriority Priority { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.Data.RelativeSource? RelativeSource { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public string? StringFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public object TargetNullValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.Data.InstancedBinding? Initiate(Avalonia.AvaloniaObject target, Avalonia.AvaloniaProperty? targetProperty, object? anchor = null, bool enableDataValidation = false) { throw null; }
    }
    public partial class RelativeSource
    {
        public RelativeSource() { }
        public RelativeSource(Avalonia.Data.RelativeSourceMode mode) { }
        public int AncestorLevel { get { throw null; } set { } }
        public System.Type? AncestorType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.Data.RelativeSourceMode Mode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.Data.TreeType Tree { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
    }
    public enum RelativeSourceMode
    {
        DataContext = 0,
        TemplatedParent = 1,
        Self = 2,
        FindAncestor = 3,
    }
    public partial class TemplateBinding : Avalonia.Reactive.SingleSubscriberObservableBase<object?>, Avalonia.Data.IBinding, Avalonia.IDescription, Avalonia.Styling.ISetterValue, System.IObservable<object?>, System.IObserver<object?>
    {
        public TemplateBinding() { }
        public TemplateBinding(Avalonia.AvaloniaProperty property) { }
        public Avalonia.Data.Converters.IValueConverter? Converter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public object? ConverterParameter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public string Description { get { throw null; } }
        public Avalonia.Data.BindingMode Mode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public Avalonia.AvaloniaProperty? Property { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        void Avalonia.Styling.ISetterValue.Initialize(Avalonia.Styling.ISetter setter) { }
        public Avalonia.Data.InstancedBinding? Initiate(Avalonia.AvaloniaObject target, Avalonia.AvaloniaProperty? targetProperty, object? anchor = null, bool enableDataValidation = false) { throw null; }
        public Avalonia.Data.IBinding ProvideValue() { throw null; }
        protected override void Subscribed() { }
        void System.IObserver<object?>.OnCompleted() { }
        void System.IObserver<object?>.OnError(System.Exception error) { }
        void System.IObserver<object?>.OnNext(object? value) { }
        protected override void Unsubscribed() { }
    }
    public enum TreeType
    {
        Visual = 0,
        Logical = 1,
    }
}
namespace Avalonia.Markup.Data
{
    public static partial class DelayedBinding
    {
        public static void Add(Avalonia.StyledElement target, Avalonia.AvaloniaProperty property, Avalonia.Data.IBinding binding) { }
        public static void Add(Avalonia.StyledElement target, System.Reflection.PropertyInfo property, System.Func<Avalonia.StyledElement, object?> value) { }
        public static void ApplyBindings(Avalonia.StyledElement control) { }
    }
}
namespace Avalonia.Markup.Parsers
{
    public static partial class ArgumentListParser
    {
        public static System.Collections.Generic.IList<string> ParseArguments(this ref Avalonia.Utilities.CharacterReader r, char open, char close, char delimiter = ',') { throw null; }
    }
    public partial class PropertyPathGrammar
    {
        public PropertyPathGrammar() { }
        public static System.Collections.Generic.IEnumerable<Avalonia.Markup.Parsers.PropertyPathGrammar.ISyntax> Parse(string s) { throw null; }
        public partial class CastTypeSyntax : Avalonia.Markup.Parsers.PropertyPathGrammar.ISyntax
        {
            public CastTypeSyntax() { }
            public string TypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
            public string? TypeNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
            public override bool Equals(object? obj) { throw null; }
        }
        public partial class ChildTraversalSyntax : Avalonia.Markup.Parsers.PropertyPathGrammar.ISyntax
        {
            public ChildTraversalSyntax() { }
            public static Avalonia.Markup.Parsers.PropertyPathGrammar.ChildTraversalSyntax? Instance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } }
            public override bool Equals(object? obj) { throw null; }
        }
        public partial class EnsureTypeSyntax : Avalonia.Markup.Parsers.PropertyPathGrammar.ISyntax
        {
            public EnsureTypeSyntax() { }
            public string TypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
            public string? TypeNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
            public override bool Equals(object? obj) { throw null; }
        }
        public partial interface ISyntax
        {
        }
        public partial class PropertySyntax : Avalonia.Markup.Parsers.PropertyPathGrammar.ISyntax
        {
            public PropertySyntax() { }
            public string? Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
            public override bool Equals(object? obj) { throw null; }
        }
        public partial class TypeQualifiedPropertySyntax : Avalonia.Markup.Parsers.PropertyPathGrammar.ISyntax
        {
            public TypeQualifiedPropertySyntax() { }
            public string? Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
            public string? TypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
            public string? TypeNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
            public override bool Equals(object? obj) { throw null; }
        }
    }
    public partial class SelectorParser
    {
        public SelectorParser(System.Func<string, string, System.Type> typeResolver) { }
        [System.Diagnostics.CodeAnalysis.RequiresUnreferencedCodeAttribute("Selectors runtime parser might require unreferenced code. Consider using stronly typed selectors factory with 'new Style(s => s.OfType<Button>())' syntax.")]
        public Avalonia.Styling.Selector? Parse(string s) { throw null; }
    }
}
