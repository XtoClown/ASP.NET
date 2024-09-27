using Microsoft.Extensions.Configuration;

namespace lr_two.Services
{
    public interface ITestService
    {
        string Send();
        string InfoAboutAuthor();
    }
    public class TestService: ITestService
    {
        private readonly IConfiguration configuration;
        public TestService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public string Send()
        {
            var jsonResult = JsonCompanyHighestStaff();
            var jsonResultString = $"JSON FILE HIGHEST STAFF: {PrettyPrintJson(jsonResult)}";

            var xmlResult = XmlCompanyHighestStaff();
            var xmlResultString = $"XML FILE HIGHEST STAFF: {PrettyPrintXml(xmlResult)}";

            var iniResult = IniCompanyHighestStaff();
            var iniResultString = $"INI FILE HIGHEST STAFF: {PrettyPrintIni(iniResult)}";

            return jsonResultString + xmlResultString + iniResultString;
        }
        public string InfoAboutAuthor()
        {
            var name = configuration.GetSection("Author").GetValue<string>("name");
            var group = configuration.GetSection("Author").GetValue<int>("group");
            var age = configuration.GetSection("Author").GetValue<int>("age");
            var born = configuration.GetSection("Author").GetValue<string>("born");
            var nationality = configuration.GetSection("Author").GetValue<string>("nationality");
            var city = configuration.GetSection("Author").GetValue<string>("city");
            var tg = configuration.GetSection("Author").GetValue<string>("tg");
            return $"Author name: {name}\nAuthor group: {group}\nAuthor age: {age}\nBorn: {born}\nNationality: {nationality}\nCity: {city}\nTelegram: {tg}";
        }
        private string PrettyPrintJson(String result)
        {
            if (result == "Microsoft")
            {
                var companyFullName = configuration.GetSection("CompanyJSON:MicrosoftJSON").GetValue<string>("fullName");
                var companyStaff = configuration.GetSection("CompanyJSON:MicrosoftJSON").GetValue<int>("staff");
                var companyAssets = configuration.GetSection("CompanyJSON:MicrosoftJSON").GetValue<double>("assetsBillions");
                var companyCapitalization = configuration.GetSection("CompanyJSON:MicrosoftJSON").GetValue<double>("capitalizationTrillions");
                return $"Company name: {companyFullName} | Company staff: {companyStaff} people | Company assets: {companyAssets} billions $ | Company capitalization: {companyCapitalization} trillions $\n";
            }
            else if (result == "Apple")
            {
                var companyFullName = configuration.GetSection("CompanyJSON:AppleJSON").GetValue<string>("fullName");
                var companyStaff = configuration.GetSection("CompanyJSON:AppleJSON").GetValue<int>("staff");
                var companyAssets = configuration.GetSection("CompanyJSON:AppleJSON").GetValue<double>("assetsBillions");
                var companyCapitalization = configuration.GetSection("CompanyJSON:AppleJSON").GetValue<double>("capitalizationTrillions");
                return $"Company name: {companyFullName} | Company staff: {companyStaff} people | Company assets: {companyAssets} billions $ | Company capitalization: {companyCapitalization} trillions $\n";
            }
            else if (result == "Google")
            {
                var companyFullName = configuration.GetSection("CompanyJSON:GoogleJSON").GetValue<string>("fullName");
                var companyStaff = configuration.GetSection("CompanyJSON:GoogleJSON").GetValue<int>("staff");
                var companyAssets = configuration.GetSection("CompanyJSON:GoogleJSON").GetValue<double>("assetsBillions");
                var companyCapitalization = configuration.GetSection("CompanyJSON:GoogleJSON").GetValue<double>("stcapitalizationTrillionsaff");
                return $"Company name: {companyFullName} | Company staff: {companyStaff} people | Company assets: {companyAssets} billions $ | Company capitalization: {companyCapitalization} trillions $\n";
            }
            else
            {
                return "Error";
            }
        }
        private string JsonCompanyHighestStaff()
        {
            var microsoftStaff = configuration.GetSection("CompanyJSON:MicrosoftJSON").GetValue<int>("staff");
            var appleStaff = configuration.GetSection("CompanyJSON:AppleJSON").GetValue<int>("staff");
            var googleStaff = configuration.GetSection("CompanyJSON:GoogleJSON").GetValue<int>("staff");
            if (microsoftStaff > appleStaff && microsoftStaff > googleStaff)
            {
                return "Microsoft";
            }
            else if (appleStaff > microsoftStaff && appleStaff > googleStaff)
            {
                return "Apple";
            }
            else if (googleStaff > microsoftStaff && googleStaff > appleStaff)
            {
                return "Google";
            }
            else
            {
                return "Error";
            }
        }
        private string PrettyPrintXml(String result)
        {
            if (result == "Microsoft")
            {
                var companyFullName = configuration.GetSection("CompanyXML:MicrosoftXML").GetValue<string>("fullName");
                var companyStaff = configuration.GetSection("CompanyXML:MicrosoftXML").GetValue<int>("staff");
                var companyAssets = configuration.GetSection("CompanyXML:MicrosoftXML").GetValue<double>("assetsBillions");
                var companyCapitalization = configuration.GetSection("CompanyXML:MicrosoftXML").GetValue<double>("capitalizationTrillions");
                return $"Company name: {companyFullName} | Company staff: {companyStaff} people | Company assets: {companyAssets} billions $ | Company capitalization: {companyCapitalization} trillions $\n";
            }
            else if (result == "Apple")
            {
                var companyFullName = configuration.GetSection("CompanyXML:AppleXML").GetValue<string>("fullName");
                var companyStaff = configuration.GetSection("CompanyXML:AppleXML").GetValue<int>("staff");
                var companyAssets = configuration.GetSection("CompanyXML:AppleXML").GetValue<double>("assetsBillions");
                var companyCapitalization = configuration.GetSection("CompanyXML:AppleXML").GetValue<double>("capitalizationTrillions");
                return $"Company name: {companyFullName} | Company staff: {companyStaff} people | Company assets: {companyAssets} billions $ | Company capitalization: {companyCapitalization} trillions $\n";
            }
            else if (result == "Google")
            {
                var companyFullName = configuration.GetSection("CompanyXML:GoogleXML").GetValue<string>("fullName");
                var companyStaff = configuration.GetSection("CompanyXML:GoogleXML").GetValue<int>("staff");
                var companyAssets = configuration.GetSection("CompanyXML:GoogleXML").GetValue<double>("assetsBillions");
                var companyCapitalization = configuration.GetSection("CompanyXML:GoogleXML").GetValue<double>("capitalizationTrillions");
                return $"Company name: {companyFullName} | Company staff: {companyStaff} people | Company assets: {companyAssets} billions $ | Company capitalization: {companyCapitalization} trillions $\n";
            }
            else
            {
                return "Error";
            }
        }
        private string XmlCompanyHighestStaff()
        {
            var microsoftStaff = configuration.GetSection("CompanyXML:MicrosoftXML").GetValue<int>("staff");
            var appleStaff = configuration.GetSection("CompanyXML:AppleXML").GetValue<int>("staff");
            var googleStaff = configuration.GetSection("CompanyXML:GoogleXML").GetValue<int>("staff");
            if (microsoftStaff > appleStaff && microsoftStaff > googleStaff)
            {
                return "Microsoft";
            }
            else if (appleStaff > microsoftStaff && appleStaff > googleStaff)
            {
                return "Apple";
            }
            else if (googleStaff > microsoftStaff && googleStaff > appleStaff)
            {
                return "Google";
            }
            else
            {
                return "Error";
            }
        }
        private string PrettyPrintIni(String result)
        {
            if (result == "Microsoft")
            {
                var companyFullName = configuration.GetSection("MicrosoftINI").GetValue<string>("fullName");
                var companyStaff = configuration.GetSection("MicrosoftINI").GetValue<int>("staff");
                var companyAssets = configuration.GetSection("MicrosoftINI").GetValue<double>("assetsBillions");
                var companyCapitalization = configuration.GetSection("MicrosoftINI").GetValue<double>("capitalizationTrillions");
                return $"Company name: {companyFullName} | Company staff: {companyStaff} people | Company assets: {companyAssets} billions $ | Company capitalization: {companyCapitalization} trillions $\n";
            }
            else if (result == "Apple")
            {
                var companyFullName = configuration.GetSection("AppleINI").GetValue<string>("fullName");
                var companyStaff = configuration.GetSection("AppleINI").GetValue<int>("staff");
                var companyAssets = configuration.GetSection("AppleINI").GetValue<double>("assetsBillions");
                var companyCapitalization = configuration.GetSection("AppleINI").GetValue<double>("capitalizationTrillions");
                return $"Company name: {companyFullName} | Company staff: {companyStaff} people | Company assets: {companyAssets} billions $ | Company capitalization: {companyCapitalization} trillions $\n";
            }
            else if (result == "Google")
            {
                var companyFullName = configuration.GetSection("GoogleINI").GetValue<string>("fullName");
                var companyStaff = configuration.GetSection("GoogleINI").GetValue<int>("staff");
                var companyAssets = configuration.GetSection("GoogleINI").GetValue<double>("assetsBillions");
                var companyCapitalization = configuration.GetSection("GoogleINI").GetValue<double>("capitalizationTrillions");
                return $"Company name: {companyFullName} | Company staff: {companyStaff} people | Company assets: {companyAssets} billions $ | Company capitalization: {companyCapitalization} trillions $\n";
            }
            else
            {
                return "Error";
            }
        }
        private string IniCompanyHighestStaff()
        {
            var microsoftStaff = configuration.GetSection("MicrosoftINI").GetValue<int>("staff");
            var appleStaff = configuration.GetSection("AppleINI").GetValue<int>("staff");
            var googleStaff = configuration.GetSection("GoogleINI").GetValue<int>("staff");
            if (microsoftStaff > appleStaff && microsoftStaff > googleStaff)
            {
                return "Microsoft";
            }
            else if (appleStaff > microsoftStaff && appleStaff > googleStaff)
            {
                return "Apple";
            }
            else if (googleStaff > microsoftStaff && googleStaff > appleStaff)
            {
                return "Google";
            }
            else
            {
                return "Error";
            }
        }
    }
}
