using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    [AddINotifyPropertyChangedInterface]
    public class PopupViewModel
    {
        private readonly ICompanyService _companyService;

        public PopupViewModel(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public CompanyModel CompanyModel { get; set; }

        public bool IsOpen { get; set; }

        public Command SaveCompany
        {
            get
            {
                return new Command(() =>
                {
                    _companyService.SaveModel(CompanyModel);

                    IsOpen = false;
                });
            }
        }

    }
}
