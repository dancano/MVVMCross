using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Test5.Core.Services;

namespace Test5.Core.ViewModels
{
    public class PrimeNumberViewModel : MvxViewModel
    {
        private readonly IPrimeNumberService _primeNumberService;
        private int _n;
        private List<int> _result;
        private string _alterResult;
        private MvxCommand _getPrimesCommand;

        public PrimeNumberViewModel(IPrimeNumberService primeNumberService)
        {
            _primeNumberService = primeNumberService;
        }

        public int N { get => _n; set => SetProperty(ref _n, value); }

        public List<int> Result { get => _result; set => SetProperty(ref _result, value); }

        public string AlterResult { get => _alterResult; set => SetProperty(ref _alterResult, value); }

        public ICommand GetPrimeCommand
        {
            get
            {
                _getPrimesCommand = _getPrimesCommand ?? new MvxCommand(GetPrimesList);
                return _getPrimesCommand;
            }
        }

        public async override Task Initialize()
        {
            await base.Initialize();
            N = 0;
            GetPrimesList();
        }

        private void GetPrimesList()
        {
            Result = _primeNumberService.GeneratePrimes(N);
            AlterResult = String.Join(", ", Result);
        }
    }
}
