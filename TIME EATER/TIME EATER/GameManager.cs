namespace TIME_EATER
{
    internal class GameManager
    {
        private static string _input;
        private static int _actNumber;
        private static bool isNumber;

        static void ShowWelcomeMessage()
        {
            Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
            Console.WriteLine("이제 전투를 시작할 수 있습니다.");
            Console.WriteLine();

            Console.WriteLine("1.상태 보기");
            Console.WriteLine("2.전투 시작");
            Console.WriteLine();
        }

        static void SetActNumber()
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">> ");

            _input = Console.ReadLine();
            isNumber = int.TryParse(_input, out _actNumber); // 숫자가 아닌 값이면 _actNumber는 0 

            if(!(isNumber && _actNumber >= 0))
            {
                Console.WriteLine("잘못된 입력입니다.");
                SetActNumber();
            }

            switch (_actNumber)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("상태 보기 입니다.");
                    break;
                case 2:
                    Console.WriteLine("전투 시작 입니다.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            do
            {
                ShowWelcomeMessage();

                SetActNumber();

            } while (true);
        }
    }
}
