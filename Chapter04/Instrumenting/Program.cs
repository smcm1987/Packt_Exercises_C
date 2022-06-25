using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using static System.Console;

//write to a text file in the project folder
Trace.Listeners.Add(new TextWriterTraceListener(File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "log.txt"))));

//text writer is buffered, so tho call Flush() on all listeners after writing
Trace.AutoFlush = true;

//Debug.WriteLine("Debug is Listening!");
Trace.WriteLine("Trace is Listening!");

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("apsettings.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new("PacktSwitch", "This switch is set via a JSON config.");

configuration.GetSection("PacktSwitch").Bind(ts);

Trace.WriteLineIf(ts.TraceError, "Trace Error");
Trace.WriteLineIf(ts.TraceWarning, "Trace Warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace Info");
Trace.WriteLineIf(ts.TraceVerbose, "Trace Verbose");
