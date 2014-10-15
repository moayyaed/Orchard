using Orchard.Layouts.Framework.Drivers;
using Orchard.Layouts.Services;
using Orchard.Layouts.Settings;

namespace Orchard.Layouts.Handlers {
    public class ElementSettingsHandler : ElementEventHandlerBase {
        public override void BuildEditor(ElementEditorContext context) {
            var viewModel = context.Element.State.GetModel<CommonElementSettings>();
            var commonSettingsEditor = context.ShapeFactory.EditorTemplate(
                TemplateName: "ElementSettings.Common", 
                Model: viewModel, 
                Prefix: "CommonElementSettings");

            commonSettingsEditor.Metadata.Position = "Settings:5";
            context.EditorResult.Add(commonSettingsEditor);
        }

        public override void UpdateEditor(ElementEditorContext context) {
            BuildEditor(context);
        }
    }
}