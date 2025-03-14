namespace SystemParameter.Models {
    public class SystemParameterModel {
        public SystemParameterModel(string label, string order, bool isactive) {
        Label = label;
        Order = order;
        IsActive = isactive;
        Id = Guid.NewGuid();
    }

    public Guid Id { get; init; }
    public string Label { get; set; }
    public string Order { get; set; }
    public bool IsActive { get; set; }
    }
}