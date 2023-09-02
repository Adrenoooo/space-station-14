namespace Content.Shared.Andromeda.Clothing
{
    [RegisterComponent]
    public sealed partial class ClothingGrantTagComponent : Component
    {
        [DataField("tag", required: true), ViewVariables(VVAccess.ReadWrite)]
        public string Tag = "";

        [ViewVariables(VVAccess.ReadWrite)]
        public bool IsActive = false;
    }
}
