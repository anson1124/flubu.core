
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Service
{
     public partial class DockerServiceUpdateTask : ExternalProcessTaskBase<DockerServiceUpdateTask>
     {
        private string _service;

        
        public DockerServiceUpdateTask(string service)
        {
            ExecutablePath = "docker";
            WithArguments("service update");
_service = service;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Service command args
        /// </summary>
        public DockerServiceUpdateTask Args(string args)
        {
            WithArgumentsValueRequired("args", args.ToString());
            return this;
        }

        /// <summary>
        /// Add or update a config file on a service
        /// </summary>
        public DockerServiceUpdateTask ConfigAdd(string configAdd)
        {
            WithArgumentsValueRequired("config-add", configAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a configuration file
        /// </summary>
        public DockerServiceUpdateTask ConfigRm(string configRm)
        {
            WithArgumentsValueRequired("config-rm", configRm.ToString());
            return this;
        }

        /// <summary>
        /// Add or update a placement constraint
        /// </summary>
        public DockerServiceUpdateTask ConstraintAdd(string constraintAdd)
        {
            WithArgumentsValueRequired("constraint-add", constraintAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a constraint
        /// </summary>
        public DockerServiceUpdateTask ConstraintRm(string constraintRm)
        {
            WithArgumentsValueRequired("constraint-rm", constraintRm.ToString());
            return this;
        }

        /// <summary>
        /// Add or update a container label
        /// </summary>
        public DockerServiceUpdateTask ContainerLabelAdd(string containerLabelAdd)
        {
            WithArgumentsValueRequired("container-label-add", containerLabelAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a container label by its key
        /// </summary>
        public DockerServiceUpdateTask ContainerLabelRm(string containerLabelRm)
        {
            WithArgumentsValueRequired("container-label-rm", containerLabelRm.ToString());
            return this;
        }

        /// <summary>
        /// Credential spec for managed service account (Windows only)
        /// </summary>
        public DockerServiceUpdateTask CredentialSpec(string credentialSpec)
        {
            WithArgumentsValueRequired("credential-spec", credentialSpec.ToString());
            return this;
        }

        /// <summary>
        /// Exit immediately instead of waiting for the service to converge

        /// </summary>
        public DockerServiceUpdateTask Detach()
        {
            WithArguments("detach");
            return this;
        }

        /// <summary>
        /// Add or update a custom DNS server
        /// </summary>
        public DockerServiceUpdateTask DnsAdd(string dnsAdd)
        {
            WithArgumentsValueRequired("dns-add", dnsAdd.ToString());
            return this;
        }

        /// <summary>
        /// Add or update a DNS option
        /// </summary>
        public DockerServiceUpdateTask DnsOptionAdd(string dnsOptionAdd)
        {
            WithArgumentsValueRequired("dns-option-add", dnsOptionAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a DNS option
        /// </summary>
        public DockerServiceUpdateTask DnsOptionRm(string dnsOptionRm)
        {
            WithArgumentsValueRequired("dns-option-rm", dnsOptionRm.ToString());
            return this;
        }

        /// <summary>
        /// Remove a custom DNS server
        /// </summary>
        public DockerServiceUpdateTask DnsRm(string dnsRm)
        {
            WithArgumentsValueRequired("dns-rm", dnsRm.ToString());
            return this;
        }

        /// <summary>
        /// Add or update a custom DNS search domain
        /// </summary>
        public DockerServiceUpdateTask DnsSearchAdd(string dnsSearchAdd)
        {
            WithArgumentsValueRequired("dns-search-add", dnsSearchAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a DNS search domain
        /// </summary>
        public DockerServiceUpdateTask DnsSearchRm(string dnsSearchRm)
        {
            WithArgumentsValueRequired("dns-search-rm", dnsSearchRm.ToString());
            return this;
        }

        /// <summary>
        /// Endpoint mode (vip or dnsrr)
        /// </summary>
        public DockerServiceUpdateTask EndpointMode(string endpointMode)
        {
            WithArgumentsValueRequired("endpoint-mode", endpointMode.ToString());
            return this;
        }

        /// <summary>
        /// Overwrite the default ENTRYPOINT of the image
        /// </summary>
        public DockerServiceUpdateTask Entrypoint(string entrypoint)
        {
            WithArgumentsValueRequired("entrypoint", entrypoint.ToString());
            return this;
        }

        /// <summary>
        /// Add or update an environment variable
        /// </summary>
        public DockerServiceUpdateTask EnvAdd(string envAdd)
        {
            WithArgumentsValueRequired("env-add", envAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove an environment variable
        /// </summary>
        public DockerServiceUpdateTask EnvRm(string envRm)
        {
            WithArgumentsValueRequired("env-rm", envRm.ToString());
            return this;
        }

        /// <summary>
        /// Force update even if no changes require it
        /// </summary>
        public DockerServiceUpdateTask Force()
        {
            WithArguments("force");
            return this;
        }

        /// <summary>
        /// Add a Generic resource
        /// </summary>
        public DockerServiceUpdateTask GenericResourceAdd(string genericResourceAdd)
        {
            WithArgumentsValueRequired("generic-resource-add", genericResourceAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a Generic resource
        /// </summary>
        public DockerServiceUpdateTask GenericResourceRm(string genericResourceRm)
        {
            WithArgumentsValueRequired("generic-resource-rm", genericResourceRm.ToString());
            return this;
        }

        /// <summary>
        /// Add an additional supplementary user group to the container
        /// </summary>
        public DockerServiceUpdateTask GroupAdd(string groupAdd)
        {
            WithArgumentsValueRequired("group-add", groupAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a previously added supplementary user group from the container

        /// </summary>
        public DockerServiceUpdateTask GroupRm(string groupRm)
        {
            WithArgumentsValueRequired("group-rm", groupRm.ToString());
            return this;
        }

        /// <summary>
        /// Command to run to check health
        /// </summary>
        public DockerServiceUpdateTask HealthCmd(string healthCmd)
        {
            WithArgumentsValueRequired("health-cmd", healthCmd.ToString());
            return this;
        }

        /// <summary>
        /// Time between running the check (ms|s|m|h)
        /// </summary>
        public DockerServiceUpdateTask HealthInterval(string healthInterval)
        {
            WithArgumentsValueRequired("health-interval", healthInterval.ToString());
            return this;
        }

        /// <summary>
        /// Consecutive failures needed to report unhealthy
        /// </summary>
        public DockerServiceUpdateTask HealthRetries(int healthRetries)
        {
            WithArgumentsValueRequired("health-retries", healthRetries.ToString());
            return this;
        }

        /// <summary>
        /// Start period for the container to initialize before counting retries towards unstable (ms|s|m|h)

        /// </summary>
        public DockerServiceUpdateTask HealthStartPeriod(string healthStartPeriod)
        {
            WithArgumentsValueRequired("health-start-period", healthStartPeriod.ToString());
            return this;
        }

        /// <summary>
        /// Maximum time to allow one check to run (ms|s|m|h)
        /// </summary>
        public DockerServiceUpdateTask HealthTimeout(string healthTimeout)
        {
            WithArgumentsValueRequired("health-timeout", healthTimeout.ToString());
            return this;
        }

        /// <summary>
        /// Add a custom host-to-IP mapping (host:ip)
        /// </summary>
        public DockerServiceUpdateTask HostAdd(string hostAdd)
        {
            WithArgumentsValueRequired("host-add", hostAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a custom host-to-IP mapping (host:ip)
        /// </summary>
        public DockerServiceUpdateTask HostRm(string hostRm)
        {
            WithArgumentsValueRequired("host-rm", hostRm.ToString());
            return this;
        }

        /// <summary>
        /// Container hostname
        /// </summary>
        public DockerServiceUpdateTask Hostname(string hostname)
        {
            WithArgumentsValueRequired("hostname", hostname.ToString());
            return this;
        }

        /// <summary>
        /// Service image tag
        /// </summary>
        public DockerServiceUpdateTask Image(string image)
        {
            WithArgumentsValueRequired("image", image.ToString());
            return this;
        }

        /// <summary>
        /// Service container isolation mode
        /// </summary>
        public DockerServiceUpdateTask Isolation(string isolation)
        {
            WithArgumentsValueRequired("isolation", isolation.ToString());
            return this;
        }

        /// <summary>
        /// Add or update a service label
        /// </summary>
        public DockerServiceUpdateTask LabelAdd(string labelAdd)
        {
            WithArgumentsValueRequired("label-add", labelAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a label by its key
        /// </summary>
        public DockerServiceUpdateTask LabelRm(string labelRm)
        {
            WithArgumentsValueRequired("label-rm", labelRm.ToString());
            return this;
        }

        /// <summary>
        /// Limit CPUs
        /// </summary>
        public DockerServiceUpdateTask LimitCpu(decimal limitCpu)
        {
            WithArgumentsValueRequired("limit-cpu", limitCpu.ToString());
            return this;
        }

        /// <summary>
        /// Limit Memory
        /// </summary>
        public DockerServiceUpdateTask LimitMemory(string limitMemory)
        {
            WithArgumentsValueRequired("limit-memory", limitMemory.ToString());
            return this;
        }

        /// <summary>
        /// Logging driver for service
        /// </summary>
        public DockerServiceUpdateTask LogDriver(string logDriver)
        {
            WithArgumentsValueRequired("log-driver", logDriver.ToString());
            return this;
        }

        /// <summary>
        /// Logging driver options
        /// </summary>
        public DockerServiceUpdateTask LogOpt(string logOpt)
        {
            WithArgumentsValueRequired("log-opt", logOpt.ToString());
            return this;
        }

        /// <summary>
        /// Add or update a mount on a service
        /// </summary>
        public DockerServiceUpdateTask MountAdd(string mountAdd)
        {
            WithArgumentsValueRequired("mount-add", mountAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a mount by its target path
        /// </summary>
        public DockerServiceUpdateTask MountRm(string mountRm)
        {
            WithArgumentsValueRequired("mount-rm", mountRm.ToString());
            return this;
        }

        /// <summary>
        /// Add a network
        /// </summary>
        public DockerServiceUpdateTask NetworkAdd(string networkAdd)
        {
            WithArgumentsValueRequired("network-add", networkAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a network
        /// </summary>
        public DockerServiceUpdateTask NetworkRm(string networkRm)
        {
            WithArgumentsValueRequired("network-rm", networkRm.ToString());
            return this;
        }

        /// <summary>
        /// Disable any container-specified HEALTHCHECK
        /// </summary>
        public DockerServiceUpdateTask NoHealthcheck()
        {
            WithArguments("no-healthcheck");
            return this;
        }

        /// <summary>
        /// Do not query the registry to resolve image digest and supported platforms

        /// </summary>
        public DockerServiceUpdateTask NoResolveImage()
        {
            WithArguments("no-resolve-image");
            return this;
        }

        /// <summary>
        /// Add a placement preference
        /// </summary>
        public DockerServiceUpdateTask PlacementPrefAdd(string placementPrefAdd)
        {
            WithArgumentsValueRequired("placement-pref-add", placementPrefAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a placement preference
        /// </summary>
        public DockerServiceUpdateTask PlacementPrefRm(string placementPrefRm)
        {
            WithArgumentsValueRequired("placement-pref-rm", placementPrefRm.ToString());
            return this;
        }

        /// <summary>
        /// Add or update a published port
        /// </summary>
        public DockerServiceUpdateTask PublishAdd(string publishAdd)
        {
            WithArgumentsValueRequired("publish-add", publishAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a published port by its target port
        /// </summary>
        public DockerServiceUpdateTask PublishRm(string publishRm)
        {
            WithArgumentsValueRequired("publish-rm", publishRm.ToString());
            return this;
        }

        /// <summary>
        /// Suppress progress output
        /// </summary>
        public DockerServiceUpdateTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }

        /// <summary>
        /// Mount the container's root filesystem as read only
        /// </summary>
        public DockerServiceUpdateTask ReadOnly()
        {
            WithArguments("read-only");
            return this;
        }

        /// <summary>
        /// Number of tasks
        /// </summary>
        public DockerServiceUpdateTask Replicas(uint replicas)
        {
            WithArgumentsValueRequired("replicas", replicas.ToString());
            return this;
        }

        /// <summary>
        /// Reserve CPUs
        /// </summary>
        public DockerServiceUpdateTask ReserveCpu(decimal reserveCpu)
        {
            WithArgumentsValueRequired("reserve-cpu", reserveCpu.ToString());
            return this;
        }

        /// <summary>
        /// Reserve Memory
        /// </summary>
        public DockerServiceUpdateTask ReserveMemory(string reserveMemory)
        {
            WithArgumentsValueRequired("reserve-memory", reserveMemory.ToString());
            return this;
        }

        /// <summary>
        /// Restart when condition is met ("none"|"on-failure"|"any")
        /// </summary>
        public DockerServiceUpdateTask RestartCondition(string restartCondition)
        {
            WithArgumentsValueRequired("restart-condition", restartCondition.ToString());
            return this;
        }

        /// <summary>
        /// Delay between restart attempts (ns|us|ms|s|m|h)
        /// </summary>
        public DockerServiceUpdateTask RestartDelay(string restartDelay)
        {
            WithArgumentsValueRequired("restart-delay", restartDelay.ToString());
            return this;
        }

        /// <summary>
        /// Maximum number of restarts before giving up
        /// </summary>
        public DockerServiceUpdateTask RestartMaxAttempts(uint restartMaxAttempts)
        {
            WithArgumentsValueRequired("restart-max-attempts", restartMaxAttempts.ToString());
            return this;
        }

        /// <summary>
        /// Window used to evaluate the restart policy (ns|us|ms|s|m|h)
        /// </summary>
        public DockerServiceUpdateTask RestartWindow(string restartWindow)
        {
            WithArgumentsValueRequired("restart-window", restartWindow.ToString());
            return this;
        }

        /// <summary>
        /// Rollback to previous specification
        /// </summary>
        public DockerServiceUpdateTask Rollback()
        {
            WithArguments("rollback");
            return this;
        }

        /// <summary>
        /// Delay between task rollbacks (ns|us|ms|s|m|h)
        /// </summary>
        public DockerServiceUpdateTask RollbackDelay(string rollbackDelay)
        {
            WithArgumentsValueRequired("rollback-delay", rollbackDelay.ToString());
            return this;
        }

        /// <summary>
        /// Action on rollback failure ("pause"|"continue")
        /// </summary>
        public DockerServiceUpdateTask RollbackFailureAction(string rollbackFailureAction)
        {
            WithArgumentsValueRequired("rollback-failure-action", rollbackFailureAction.ToString());
            return this;
        }

        /// <summary>
        /// Failure rate to tolerate during a rollback
        /// </summary>
        public DockerServiceUpdateTask RollbackMaxFailureRatio(float rollbackMaxFailureRatio)
        {
            WithArgumentsValueRequired("rollback-max-failure-ratio", rollbackMaxFailureRatio.ToString());
            return this;
        }

        /// <summary>
        /// Duration after each task rollback to monitor for failure (ns|us|ms|s|m|h)

        /// </summary>
        public DockerServiceUpdateTask RollbackMonitor(string rollbackMonitor)
        {
            WithArgumentsValueRequired("rollback-monitor", rollbackMonitor.ToString());
            return this;
        }

        /// <summary>
        /// Rollback order ("start-first"|"stop-first")
        /// </summary>
        public DockerServiceUpdateTask RollbackOrder(string rollbackOrder)
        {
            WithArgumentsValueRequired("rollback-order", rollbackOrder.ToString());
            return this;
        }

        /// <summary>
        /// Maximum number of tasks rolled back simultaneously (0 to roll back all at once)

        /// </summary>
        public DockerServiceUpdateTask RollbackParallelism(ulong rollbackParallelism)
        {
            WithArgumentsValueRequired("rollback-parallelism", rollbackParallelism.ToString());
            return this;
        }

        /// <summary>
        /// Add or update a secret on a service
        /// </summary>
        public DockerServiceUpdateTask SecretAdd(string secretAdd)
        {
            WithArgumentsValueRequired("secret-add", secretAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a secret
        /// </summary>
        public DockerServiceUpdateTask SecretRm(string secretRm)
        {
            WithArgumentsValueRequired("secret-rm", secretRm.ToString());
            return this;
        }

        /// <summary>
        /// Time to wait before force killing a container (ns|us|ms|s|m|h)

        /// </summary>
        public DockerServiceUpdateTask StopGracePeriod(string stopGracePeriod)
        {
            WithArgumentsValueRequired("stop-grace-period", stopGracePeriod.ToString());
            return this;
        }

        /// <summary>
        /// Signal to stop the container
        /// </summary>
        public DockerServiceUpdateTask StopSignal(string stopSignal)
        {
            WithArgumentsValueRequired("stop-signal", stopSignal.ToString());
            return this;
        }

        /// <summary>
        /// Allocate a pseudo-TTY
        /// </summary>
        public DockerServiceUpdateTask Tty()
        {
            WithArguments("tty");
            return this;
        }

        /// <summary>
        /// Delay between updates (ns|us|ms|s|m|h)
        /// </summary>
        public DockerServiceUpdateTask UpdateDelay(string updateDelay)
        {
            WithArgumentsValueRequired("update-delay", updateDelay.ToString());
            return this;
        }

        /// <summary>
        /// Action on update failure ("pause"|"continue"|"rollback")
        /// </summary>
        public DockerServiceUpdateTask UpdateFailureAction(string updateFailureAction)
        {
            WithArgumentsValueRequired("update-failure-action", updateFailureAction.ToString());
            return this;
        }

        /// <summary>
        /// Failure rate to tolerate during an update
        /// </summary>
        public DockerServiceUpdateTask UpdateMaxFailureRatio(float updateMaxFailureRatio)
        {
            WithArgumentsValueRequired("update-max-failure-ratio", updateMaxFailureRatio.ToString());
            return this;
        }

        /// <summary>
        /// Duration after each task update to monitor for failure (ns|us|ms|s|m|h)

        /// </summary>
        public DockerServiceUpdateTask UpdateMonitor(string updateMonitor)
        {
            WithArgumentsValueRequired("update-monitor", updateMonitor.ToString());
            return this;
        }

        /// <summary>
        /// Update order ("start-first"|"stop-first")
        /// </summary>
        public DockerServiceUpdateTask UpdateOrder(string updateOrder)
        {
            WithArgumentsValueRequired("update-order", updateOrder.ToString());
            return this;
        }

        /// <summary>
        /// Maximum number of tasks updated simultaneously (0 to update all at once)

        /// </summary>
        public DockerServiceUpdateTask UpdateParallelism(ulong updateParallelism)
        {
            WithArgumentsValueRequired("update-parallelism", updateParallelism.ToString());
            return this;
        }

        /// <summary>
        /// Username or UID (format: <name|uid>[:<group|gid>])
        /// </summary>
        public DockerServiceUpdateTask User(string user)
        {
            WithArgumentsValueRequired("user", user.ToString());
            return this;
        }

        /// <summary>
        /// Send registry authentication details to swarm agents
        /// </summary>
        public DockerServiceUpdateTask WithRegistryAuth()
        {
            WithArguments("with-registry-auth");
            return this;
        }

        /// <summary>
        /// Working directory inside the container
        /// </summary>
        public DockerServiceUpdateTask Workdir(string workdir)
        {
            WithArgumentsValueRequired("workdir", workdir.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_service);

            return base.DoExecute(context);
        }

     }
}
