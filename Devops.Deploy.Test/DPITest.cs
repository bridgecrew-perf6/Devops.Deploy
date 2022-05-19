using Devops.Deploy.Clients;
using Devops.Deploy.Injectors;
using Devops.Deploy.Interfaces;
using Devops.Deploy.Records;
using Newtonsoft.Json;
using Ninject;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Devops.Deploy.Tests
{
    public class DPITest
    {
        IReleaseService ReleaseService;
        IRelease Release;
        List<ReleaseRecord> releaseRecords;

        public DPITest()
        {
            var kernel = new StandardKernel(new GeneralInjector());

            ReleaseService = kernel.Get<ReleaseClient>().releaseService;
            Release = kernel.Get<ReleaseClient>().release;
            using (StreamReader file = File.OpenText(@"C:\Users\wilken.lues\source\repos\Devops.Deploy\Devops.Deploy.Test\TestData\Releases.json"))
                releaseRecords = JsonConvert.DeserializeObject<List<ReleaseRecord>>(file.ReadToEnd());
        }

        [Fact]
        public void When_Given_JSON_Object_Is_Instantiated()
        {
            //Arrange
            var releases = new List<IRelease>();
            //Act
            releaseRecords.ForEach(n =>
            {
                Release.releaseRecord = n;
                releases.Add(Release);
            });
            //Assert
            releases.ForEach(n =>
            {
                Assert.NotNull(n);
            });
        }



        [Fact]
        public void When_Given_JSON_Object_Properties_Are_Populated()
        {
            //Arrange
            var releases = new List<IRelease>();
            //Act
            releaseRecords.ForEach(n =>
            {
                Release.releaseRecord = n;
                releases.Add(Release);
            });
            //Assert
            var release = releases.Where(x=>x.Id== "Release-6");
            Assert.NotNull(release);
        }

     
        [Fact]
        public void When_Given_ReleaseJSON_List_Count_Eight()
        {
            //Arrange
            var releases = new List<IRelease>();
            //Act
            releaseRecords.ForEach(n =>
            {
                Release.releaseRecord = n;
                releases.Add(Release);
            });
            //Assert
            Assert.Equal(8, releases.Count);
        }
    }
}
