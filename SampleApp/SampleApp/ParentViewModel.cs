using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SampleApp
{
    [AddINotifyPropertyChangedInterface]
    public class ParentViewModel
    {
        private readonly ICompanyService _companyService;

        public ParentViewModel(PopupViewModel popupViewModel, ICompanyService companyService)
        {
            PopupViewModel = popupViewModel;
            _companyService = companyService;
        }

        public PopupViewModel PopupViewModel { get; set; }

        public Command OpenChild
        {
            get
            {
                return new Command(() =>
                {
                    PopupViewModel.CompanyModel = _companyService.GetCompany();
                    PopupViewModel.IsOpen = true;
                });
            }
        }
    }
}
