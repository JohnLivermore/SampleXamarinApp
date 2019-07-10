using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApp
{
    public interface ICompanyService
    {
        CompanyModel GetCompany();
        bool SaveModel(CompanyModel companyModel);
    }

    public class CompanyService : ICompanyService
    {
        public CompanyModel GetCompany()
        {
            return new CompanyModel()
            {
                CompanyName = "Telerik"
            };
        }

        public bool SaveModel(CompanyModel companyModel)
        {
            return true;
        }
    }
}
