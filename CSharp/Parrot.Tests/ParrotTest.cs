using Xunit;

namespace Parrot.Tests
{
    public class ParrotTest
    {
        [Fact]
        public void GetSpeedNorwegianBlueParrot_nailed()
        {
            var parrot = Parrot.CreateInstance((ParrotTypeEnum)ParrotTypeEnum.NORWEGIAN_BLUE, (int)0, (double)0, (bool)true);
            Assert.Equal(0.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed()
        {
            var parrot = Parrot.CreateInstance((ParrotTypeEnum)ParrotTypeEnum.NORWEGIAN_BLUE, (int)0, (double)1.5, (bool)false);
            Assert.Equal(18.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedNorwegianBlueParrot_not_nailed_high_voltage()
        {
            var parrot = Parrot.CreateInstance((ParrotTypeEnum)ParrotTypeEnum.NORWEGIAN_BLUE, (int)0, (double)4, (bool)false);
            Assert.Equal(24.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_No_Coconuts()
        {
            var parrot = Parrot.CreateInstance((ParrotTypeEnum)ParrotTypeEnum.AFRICAN, (int)0, (double)0, (bool)false);
            Assert.Equal(12.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_One_Coconut()
        {
            var parrot = Parrot.CreateInstance((ParrotTypeEnum)ParrotTypeEnum.AFRICAN, (int)1, (double)0, (bool)false);
            Assert.Equal(3.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfAfricanParrot_With_Two_Coconuts()
        {
            var parrot = Parrot.CreateInstance((ParrotTypeEnum)ParrotTypeEnum.AFRICAN, (int)2, (double)0, (bool)false);
            Assert.Equal(0.0, parrot.GetSpeed());
        }

        [Fact]
        public void GetSpeedOfEuropeanParrot()
        {
            var parrot = Parrot.CreateInstance((ParrotTypeEnum)ParrotTypeEnum.EUROPEAN, (int)0, (double)0, (bool)false);
            Assert.Equal(12.0, parrot.GetSpeed());
        }
    }
}