﻿using Xunit;

namespace Identity.Dapper.Tests.SqlQueryParameters
{
    public class UpdateQuerySetFragmentTests
    {
        [Fact]
        public void UpdateQuerySetFragmentTest()
        {
            var values = new string[]
            {
                "A",
                "\"B\"",
                "C",
                "\"D\""
            };

            const string expected = "SET A = @A, \"B\" = @B, C = @C, \"D\" = @D";

            Assert.Equal(expected,
                         values.UpdateQuerySetFragment("@"));
        }
    }
}
