namespace functions
{
    public class ReportGenerator
    {
        public void CreateReport(string excelFile)
        {
            try
            {
                validateFile(excelFile);
            }
            catch (FileNotFoundException exc)
            {

                throw exc;
            }
        }

        private bool validateFile(string path)
        {
            if (!File.Exists(path) &&
                 IsSchemeExpected())
            {
                throw new FileNotFoundException($"{path} isimli bir dosya bulunamdı");
            }
            //diğer denetimler....

            return true;

        }

        bool excelFileIsExist(string path)
        {
            return File.Exists(path);
        }

        bool IsSchemeExpected()
        {
            return false;
        }
    }
}
