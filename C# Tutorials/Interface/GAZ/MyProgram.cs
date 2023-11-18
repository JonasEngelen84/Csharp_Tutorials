namespace Interface.Gaz
{
    class MyProgram
    {
        private readonly ILogger _logger;
        public MyProgram(ILogger logger)
        {
            _logger = logger;
        }
        public void MakeSometingRight()
        {
            _logger.LogInfo("Something went right");
        }
        public void MakeSometingWrong()
        {
            _logger.LogError("Something went wrong");
        }
    }
}
