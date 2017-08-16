namespace Flightaware1
{
    class FAExtract
    {
        public static void Main2(string[] args)
        {

            Trace.Listeners.Clear();

            //TextWriterTraceListener twtl = new TextWriterTraceListener(Path.Combine(Path.GetTempPath(), AppDomain.CurrentDomain.FriendlyName));
            TextWriterTraceListener twtl = new TextWriterTraceListener("d:\\textlogger.log");
            twtl.Name = "TextLogger";
            twtl.TraceOutputOptions = TraceOptions.ThreadId | TraceOptions.DateTime;

            ConsoleTraceListener ctl = new ConsoleTraceListener(false);
            ctl.TraceOutputOptions = TraceOptions.DateTime;