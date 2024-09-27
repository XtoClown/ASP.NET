namespace lr_one
{
    public class Company
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string[] Countries { get; set; }
        public int Staff { get; set; }
        public Company()
        {
            this.Name = "";
            this.Type = "";
            this.Countries = [];
            this.Staff = 0;
        }
        public override string ToString()
        {
            return $"Info about object \nCompany name: {this.Name} \nCompany type: {this.Type} \nСompany branches: {string.Join(", ", this.Countries)} \nCompany staff: {this.Staff} people \n";
        }
    }
}
