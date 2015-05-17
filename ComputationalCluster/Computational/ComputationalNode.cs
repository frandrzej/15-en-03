﻿using ComputationalCluster.Shared.Messages.StatusNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ComputationalCluster.Shared.Utilities;
using ComputationalCluster.Shared.Messages.RegisterNamespace;
using System.Threading;
using ComputationalCluster.Shared.Connection;

namespace ComputationalCluster.Nodes
{
    public class ComputationalNode : Node
    {
        public ComputationalNode()
        {
            nodeType = NodeType.ComputationalNode;
        }

        public void startInstance(Int32 port, String hostName, Int32 timeout) {
            this.Timeout = timeout;
            this.Port = port;
            this.HostName = hostName;
            
            Console.WriteLine("Computational Node Started");
            String message = "";

            Register register = new Register();
            message = register.SerializeToXML();

            CMSocket.Instance.SendMessage(port, HostName, message);

            while (true) {
                Thread.Sleep(Timeout);
                Status _status = new Status();
                message = _status.SerializeToXML();
                CMSocket.Instance.SendMessage(port, HostName, message);
            } 
        }   
    }
}