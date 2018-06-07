﻿using Xunit;

namespace Identity.Dapper.Tests
{
    public class ReplaceInsertQueryParametersTests
    {
        [Fact]
        public void ReplaceInsertQueryParametersTest()
        {
            const string query = "INSERT INTO %SCHEMA%.%TABLENAME% %COLUMNS% VALUES(%VALUES%)";
            const string expected = "INSERT INTO dbo.IdentityUser (A, B, C) VALUES(@A, @B, @C)";

            Assert.Equal(expected,
                         query.ReplaceInsertQueryParameters("dbo",
                                                            "IdentityUser",
                                                            "A, B, C",
                                                            "@A, @B, @C"));
        }
    }
}
