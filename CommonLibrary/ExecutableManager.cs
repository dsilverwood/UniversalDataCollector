using System.Data;

namespace CommonLibrary
{
    public class SensorExecutableManager
    {
        private const string installRoot = "/home/pi/UniversalDataCollector";

        private Raspberry myRaspberry;

        void Initialize(string configFilename)
        {
            myRaspberry = new Raspberry();
            myRaspberry.Initialize(configFilename);
        }

        public bool IsInstallationOK()
        {
            return true;
        }

        public void Install()
        {

        }

        public bool CreateLinuxFolders()
        {
            bool success = true;

            if (!myRaspberry.ExecuteBashCommand("[ -d " + installRoot + " ]"))
                success &= myRaspberry.ExecuteBashCommand("mkdir " + installRoot);
            if(!myRaspberry.ExecuteBashCommand("[ -d " + installRoot + "/SensorTemplates ]"))
                success &= myRaspberry.ExecuteBashCommand("mkdir " + installRoot + "/SensorTemplates");
            if(!myRaspberry.ExecuteBashCommand("[ -d " + installRoot + "/ActiveSensors]"))
                success &= myRaspberry.ExecuteBashCommand("mkdir " + installRoot + "/ActiveSensors");

            return success;
        }

        private bool CopyInstallationFiles()
        {
            return true;
        }

        public bool AddActiveSensors()
        {
            bool success = true;
            DataSet sensorConfig = myRaspberry.SensorConfig();
            foreach(DataRow row in sensorConfig.Tables[0].Rows)
            {
                 success &= myRaspberry.ExecuteBashCommand("cp " + installRoot + "/SensorTemplates/" + row.ItemArray[6] + " " + installRoot + "/ActiveSensors/" + row.ItemArray[0].ToString() + "_" + row.ItemArray[6].ToString());
            }
            return success;
        }

        public bool ClearActiveSensors()
        {
            bool success = myRaspberry.ExecuteBashCommand("rm " + installRoot + "/ActiveSensors/*");
            return success;
        }
    }
}
