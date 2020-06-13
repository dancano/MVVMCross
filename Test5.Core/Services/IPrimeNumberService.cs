using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Test5.Core.Services
{
    public interface IPrimeNumberService
    {
        List<int> GeneratePrimes(int n);
    }
}
