//------------------------------------------------------------------------------
// C #   I N   A C T I O N   ( C S A )
//------------------------------------------------------------------------------
// Repository:
//    $Id: IOPortEx.cs 840 2012-10-02 19:04:22Z zajost $
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace RobotIO
{
    public class IOPortEx
    {
        /// <summary>
        /// Schreibt ein Byte auf eine Port-Adresse
        /// </summary>
        /// <param name="port">die gewünschte Port-Adresse (16 Bit)</param>
        /// <param name="data">das gewünschte Datenbyte</param>
        public static void Write(int port, int data)
        {
            WriteByte((ushort)port, (byte)data);
        }

        /// <summary>
        /// Liest ein Byte von einer Port-Adresse
        /// </summary>
        /// <param name="port">die gewünschte Port-Adresse (16 Bit)</param>
        /// <returns>das gelesene Byte</returns>
        public static int Read(int port)
        {
            return ReadByte((ushort)port);
        }
        
        [DllImport("CEDDK.dll", EntryPoint = "WRITE_PORT_UCHAR", CharSet = CharSet.Auto)]
        private static extern void WriteByte(ushort Addr, byte Value);

        [DllImport("CEDDK.dll", EntryPoint = "READ_PORT_UCHAR", CharSet = CharSet.Auto)]
        private static extern byte ReadByte(ushort Addr);
 

    }
}
