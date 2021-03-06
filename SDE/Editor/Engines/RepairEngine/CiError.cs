using SDE.Editor.Generic.Lists;
using SDE.View.ObjectView;

namespace SDE.Editor.Engines.RepairEngine
{
    public class CiError : ValidationErrorView
    {
        public CiError(ValidationErrors type, int itemId, string message, ServerDbs db, DbValidationEngine validationEngine) : base(type, itemId, message, db, validationEngine)
        {
        }
    }
}