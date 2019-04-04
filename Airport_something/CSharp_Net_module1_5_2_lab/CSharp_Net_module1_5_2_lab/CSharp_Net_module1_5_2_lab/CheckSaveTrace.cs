using System;
using System.Diagnostics;
using AirplaneLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_5_2_lab
{
    //immplement class CheckSaveTrace:IDisposable
    public class CheckSaveTrace:IDisposable
    {
        //define  TraceSource and EventLog  fields
        private  TraceSource trc = null;
        private  EventLog evlog = null;

        //implement CheckSaveTrace() constructor with two methods calling
        //    initEventLog with assembly name as argument
        //    initTrace with assembly name as argument
        internal CheckSaveTrace()
        {
            string AssemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name; 
            initEventLog(AssemblyName);
            initTrace(AssemblyName);
        }

        //implement Dispose(bool disposing) method
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                {
                    //realize EventLog object closing and disposing
                    evlog.Close();
                    evlog.Dispose();
                    //realize TraceSource object flushing and closing 
                    trc.Flush();
                    trc.Close();
                }
            }
        }

        //implement Dispose() method
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //implement ~CheckSaveTrace()
        ~CheckSaveTrace()
        {
            Dispose(false);
        }

        //implement initEventLog method with assembly name as argument
         void initEventLog(string AppName)
        {
            // check EventLog.SourceExists and CreateEventSource 
            if (!EventLog.SourceExists(AppName))
                EventLog.CreateEventSource(
                    AppName, "Application");
            evlog = new EventLog();
            evlog.Source = AppName;
        }

        //implement   initTrace  method with assembly name as argument
         void initTrace(string AppName)
        {
            // First step: create the trace source object
            TraceSource ts = new TraceSource(AppName + "_TraceSource");

            // Second step: create TextWriterTraceListener trace listener
            TextWriterTraceListener tr = new TextWriterTraceListener(AppName+".log");

            // Third step: configuring our trace source and trace listeners
            ts.Switch = new SourceSwitch(AppName + "_Switch", AppName + " switch");
            ts.Switch.Level = SourceLevels.All; // Enable only warning, error and critical events

            // Configuring trace listeners
            tr.TraceOutputOptions = TraceOptions.DateTime;

            // Adding our trace listeners
            ts.Listeners.Clear();
            ts.Listeners.Add(tr);

            // Setting autoflush to save files automatically
            Trace.AutoFlush = true;

            trc = ts;

        }

        //implement  CheckClassAttribute(object obj) method
        //for  attributes output
        internal void CheckClassAttribute(object obj)
        {
            Console.WriteLine(string.Format("\r\n------- ATTRIBUTES OF {0} ------", obj.GetType()));
            var attributes = obj.GetType().GetCustomAttributes(false);

            foreach (var attr in attributes)
            {
                var fields = attr.GetType().GetFields();
                foreach (var field in fields)
                {
                    Console.WriteLine(string.Format("field {0} \t\t value {1}", field.FieldType.Name, field.GetValue(attr)));
                }

                var properties = attr.GetType().GetProperties();
                foreach (var property in properties)
                {
                    Console.WriteLine(string.Format("property {0} \t\t value {1}", property.GetType().Name, property.GetValue(attr, null)));
                }
                Console.WriteLine("------- END OF ATTRIBUTE ------");
            }
        }

        //implement SaveTrace(object obj) method
        //for obj attributes tracing
        internal void SaveTrace(object obj)
        {
            //use  TraceEvent for information tracing
            trc.TraceEvent(TraceEventType.Information, 0, obj.GetType().Name);

            object[] attr = obj.GetType().GetCustomAttributes(true);
            for (int i = 0; i < attr.Length; i++)
            {
                var value = attr[i];

                trc.TraceEvent(TraceEventType.Information, 0, value.ToString());
                if (typeof(AirplaneTypeAttribute).IsInstanceOfType(value))
                {
                    AirplaneTypeAttribute at = (AirplaneTypeAttribute)value;
                    trc.TraceEvent(TraceEventType.Information, 0, at.Type.ToString());
                }
            }
        }

        //implement EventLogging(object obj) method
        //for obj attributes logging
        internal void EventLogging(object obj)
        {
            string logStr = obj.GetType().Name + "\r\n";
            var attributes = obj.GetType().GetCustomAttributes(false);
            foreach (var attr in attributes)
            {

                var properties = attr.GetType().GetProperties();             
                foreach (var property in properties)
                {
                    logStr += string.Format("{0} \t",  property.GetValue(attr, null));
                }
                logStr += "\r\n";            
            }
            // use EventLog WriteEntry method
            evlog.WriteEntry(logStr);
        }


    }
}
