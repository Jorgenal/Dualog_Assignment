using System;
using System.Globalization;
using Xunit;	// Installed Xunit nuget package, MSTest.TestAdapter, Microsoft.NET.Test.Sdk, and xunit.runner.visualstudio
                // Allowed me to run tests through visual studio


namespace UnitTests
{
    public class UnitTest_Vessel
    {

        [Fact]
        public void Update_Name_Vessel()
        {
            Vessel vessel = new Vessel("test_name", 2015, 40);
            vessel.SetName("new_name");

            Assert.Equal("new_name", vessel.GetName());
        }

        [Fact]
        public void Throw_Exception_On_Null_Name()
        {
            Assert.Throws<ArgumentNullException>(() => new Vessel(null, 2015, 40));
        }

        [Fact]
        public void Update_YearBuilt_Vessel()
        {
            Vessel vessel = new Vessel("test_name", 2015, 40);
            vessel.SetYearBuilt(2019);

            Assert.Equal(2019, vessel.GetYearBuilt());
        }

        [Fact]
        public void OldShipException_If_Ship_Is_Too_Old()
        {
            Assert.Throws<OldShipException>(() => new Vessel("test_name", 1950, 40));
        }

        [Fact]
        public void Update_Knots_Vessel()
        {
            Vessel vessel = new Vessel("test_name", 2015, 40);
            vessel.SetKnots(50);

            Assert.Equal(50, vessel.GetKnots());
        }

        [Fact]
        public void Throw_Invalid_Knots_Range_Upper_Exception()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Vessel("test_name", 2015, 500));
        }

        [Fact]
        public void Throw_Invalid_Knots_Range_Lower_Exception()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Vessel("test_name", 2015, -1));
        }

        [Fact]
        public void Get_Knots_Format_From_IFormattableInterface()
        {
            Vessel vessel = new Vessel("test_name", 2015, 40);
            NumberFormatInfo current = NumberFormatInfo.CurrentInfo;

            Assert.Equal("40 kn", vessel.ToString("KN", current));
        }

        [Fact]
        public void Get_MetersPerSec_Format_From_IFormattableInterface()
        {
            Vessel vessel = new Vessel("test_name", 2015, 40);
            NumberFormatInfo current = NumberFormatInfo.CurrentInfo;

            Assert.Equal("20,57777777777783 m/s", vessel.ToString("MS", current));
        }

        [Fact]
        public void Throw_FormatException_On_Invalid_Format()
        {
            Vessel vessel = new Vessel("test_name", 2015, 40);
            NumberFormatInfo current = NumberFormatInfo.CurrentInfo;

            Assert.Throws<FormatException>(() => vessel.ToString("KM", current));
        }
    }

    public class UnitTest_Ferry
    {
        [Fact]
        public void Check_Default_Passenger_Value_FerryClass()
        {
            Ferry ferry = new Ferry("test_ferry", 2015, 40);

            Assert.Equal(20, ferry.GetPassengers());
        }

        [Fact]
        public void Set_New_Passenger_Value_FerryClass()
        {
            Ferry ferry = new Ferry("test_ferry", 2015, 40);
            ferry.SetPassengers(30);

            Assert.Equal(30, ferry.GetPassengers());
        }

        [Fact]
        public void Throw_Invalid_Passenger_Range_Upper_Exception()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Ferry("test_name", 2015, 20000));
        }

        [Fact]
        public void Throw_Invalid_Passenger_Range_Lower_Exception()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Ferry("test_name", 2015, -1));
        }
    }

    public class UnitTest_Tugboat
    {
        [Fact]
        public void Check_Default_MaxForce_Value_TugboatClass()
        {
            Tugboat tugboat = new Tugboat("test_tugboat", 2015, 40);

            Assert.Equal(15, tugboat.GetMaxForce());
        }

        [Fact]
        public void Set_New_MaxForce_Value_TugboatClass()
        {
            Tugboat tugboat = new Tugboat("test_tugboat", 2015, 40);
            tugboat.SetMaxForce(20);

            Assert.Equal(20, tugboat.GetMaxForce());
        }

        [Fact]
        public void Throw_Invalid_MaxForce_Range_Upper_Exception()
        {
            Tugboat tugboat = new Tugboat("test_tugboat", 2015, 40);

            Assert.Throws<ArgumentOutOfRangeException>(() => tugboat.SetMaxForce(6000));
        }

        [Fact]
        public void Throw_Invalid_MaxForce_Range_Lower_Exception()
        {
            Tugboat tugboat = new Tugboat("test_tugboat", 2015, 40);

            Assert.Throws<ArgumentOutOfRangeException>(() => tugboat.SetMaxForce(-1));
        }
    }

    public class UnitTest_Submarine
    {

        [Fact]
        public void Check_Default_MaxDepth_Value_SubmarineClass()
        {
            Submarine submarine = new Submarine("test_submarine", 2015, 40);

            Assert.Equal(20, submarine.GetMaxDepth());
        }

        [Fact]
        public void Set_New_MaxDepth_Value_SubmarineClass()
        {
            Submarine submarine = new Submarine("test_submarine", 2015, 40);

            submarine.SetMaxDepth(30);
            Assert.Equal(30, submarine.GetMaxDepth());
        }

        [Fact]
        public void Throw_Invalid_MaxDepth_Range_Upper_Exception()
        {
            Submarine submarine = new Submarine("test_submarine", 2015, 40);

            Assert.Throws<ArgumentOutOfRangeException>(() => submarine.SetMaxDepth(6000));
        }

        [Fact]
        public void Throw_Invalid_MaxDepth_Range_Lower_Exception()
        {
            Submarine submarine = new Submarine("test_submarine", 2015, 40);

            Assert.Throws<ArgumentOutOfRangeException>(() => submarine.SetMaxDepth(-1));
        }
    }
}


