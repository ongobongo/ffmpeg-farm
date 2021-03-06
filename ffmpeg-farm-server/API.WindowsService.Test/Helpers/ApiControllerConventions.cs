﻿using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace API.WindowsService.Test.Helpers
{
    internal class ApiControllerConventions : CompositeCustomization
    {
        internal ApiControllerConventions()
            : base(
                new HttpRequestMessageCustomization(),
                new ApiControllerCustomization(),
                new AutoMoqCustomization())
        {
        }
    }
}