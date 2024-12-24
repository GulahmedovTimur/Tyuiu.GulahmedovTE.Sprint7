using Tyuiu.GulahmedovTE.Sprint7.Task0.V5.Lib;
namespace Tyuiu.GulahmedovTE.Sprint7.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string filePath = @"C:\Users\gytim\source\repos\Tyuiu.GulahmedovTE.Sprint7\������� ����";

            AddDataToCSV(filePath);
        }

        private void AddDataToCSV(string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath, true)) // �������� ����� ��� ������
                {
                    // ������ ���������� ������� 
                    writer.WriteLine("�������; �����");
                }
            }
            catch (Exception ex)
            {
                // �������� �� ������
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}


