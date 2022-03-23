// See https://aka.ms/new-console-template for more information
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

var serial = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One );//make a serial port object

void port_DataReceived(object sender, SerialDataReceivedEventArgs e)//Represents the method that will handle the DataReceived event of a SerialPort object. 
    // Show all the incoming data in the port's buffer
{
    Console.WriteLine(serial.ReadExisting()); 
} 


serial.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived); //Indicates that data has been received through a port represented by the SerialPort object.
serial.Open(); //Opens a new serial port connection.
Console.ReadLine();//Reads up to the NewLine value in the input buffer.