
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
     public partial class DockerImportTask : ExternalProcessTaskBase<DockerImportTask>
     {
        private string _file;
private string _repository;

        
        public DockerImportTask(string file,  string repository)
        {
            ExecutablePath = "docker";
            WithArguments("import");
_file = file;
_repository = repository;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Apply Dockerfile instruction to the created image
        /// </summary>
        public DockerImportTask Change(string change)
        {
            WithArgumentsValueRequired("change", change.ToString());
            return this;
        }

        /// <summary>
        /// Set commit message for imported image
        /// </summary>
        public DockerImportTask Message(string message)
        {
            WithArgumentsValueRequired("message", message.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_file);
 WithArguments(_repository);

            return base.DoExecute(context);
        }

     }
}
