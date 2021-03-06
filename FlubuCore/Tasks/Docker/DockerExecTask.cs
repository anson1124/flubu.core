
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerExecTask : ExternalProcessTaskBase<DockerExecTask>
     {
        private string _container;
private string _command;
private string[] _arg;

        
        public DockerExecTask(string container,  string command,  params string[] arg)
        {
            ExecutablePath = "docker";
            WithArguments("exec");
_container = container;
_command = command;
_arg = arg;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Detached mode: run command in the background
        /// </summary>
        public DockerExecTask Detach()
        {
            WithArguments("detach");
            return this;
        }

        /// <summary>
        /// Override the key sequence for detaching a container
        /// </summary>
        public DockerExecTask DetachKeys(string detachKeys)
        {
            WithArgumentsValueRequired("detach-keys", detachKeys.ToString());
            return this;
        }

        /// <summary>
        /// Set environment variables
        /// </summary>
        public DockerExecTask Env(string env)
        {
            WithArgumentsValueRequired("env", env.ToString());
            return this;
        }

        /// <summary>
        /// Keep STDIN open even if not attached
        /// </summary>
        public DockerExecTask Interactive()
        {
            WithArguments("interactive");
            return this;
        }

        /// <summary>
        /// Give extended privileges to the command
        /// </summary>
        public DockerExecTask Privileged()
        {
            WithArguments("privileged");
            return this;
        }

        /// <summary>
        /// Allocate a pseudo-TTY
        /// </summary>
        public DockerExecTask Tty()
        {
            WithArguments("tty");
            return this;
        }

        /// <summary>
        /// Username or UID (format: <name|uid>[:<group|gid>])
        /// </summary>
        public DockerExecTask User(string user)
        {
            WithArgumentsValueRequired("user", user.ToString());
            return this;
        }

        /// <summary>
        /// Working directory inside the container
        /// </summary>
        public DockerExecTask Workdir(string workdir)
        {
            WithArgumentsValueRequired("workdir", workdir.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);
 WithArguments(_command);
 WithArguments(_arg);

            return base.DoExecute(context);
        }

     }
}
