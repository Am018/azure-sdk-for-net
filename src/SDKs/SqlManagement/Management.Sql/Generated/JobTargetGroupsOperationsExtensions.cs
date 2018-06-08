// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobTargetGroupsOperations.
    /// </summary>
    public static partial class JobTargetGroupsOperationsExtensions
    {
            /// <summary>
            /// Gets all target groups in an agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            public static IPage<JobTargetGroup> ListByAgent(this IJobTargetGroupsOperations operations, string resourceGroupName, string serverName, string jobAgentName)
            {
                return operations.ListByAgentAsync(resourceGroupName, serverName, jobAgentName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all target groups in an agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobTargetGroup>> ListByAgentAsync(this IJobTargetGroupsOperations operations, string resourceGroupName, string serverName, string jobAgentName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAgentWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a target group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='targetGroupName'>
            /// The name of the target group.
            /// </param>
            public static JobTargetGroup Get(this IJobTargetGroupsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName)
            {
                return operations.GetAsync(resourceGroupName, serverName, jobAgentName, targetGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a target group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='targetGroupName'>
            /// The name of the target group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobTargetGroup> GetAsync(this IJobTargetGroupsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, targetGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a target group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='targetGroupName'>
            /// The name of the target group.
            /// </param>
            /// <param name='parameters'>
            /// The requested state of the target group.
            /// </param>
            public static JobTargetGroup CreateOrUpdate(this IJobTargetGroupsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, JobTargetGroup parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, jobAgentName, targetGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a target group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='targetGroupName'>
            /// The name of the target group.
            /// </param>
            /// <param name='parameters'>
            /// The requested state of the target group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobTargetGroup> CreateOrUpdateAsync(this IJobTargetGroupsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, JobTargetGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, targetGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a target group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='targetGroupName'>
            /// The name of the target group.
            /// </param>
            public static void Delete(this IJobTargetGroupsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, jobAgentName, targetGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a target group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server.
            /// </param>
            /// <param name='jobAgentName'>
            /// The name of the job agent.
            /// </param>
            /// <param name='targetGroupName'>
            /// The name of the target group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IJobTargetGroupsOperations operations, string resourceGroupName, string serverName, string jobAgentName, string targetGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, jobAgentName, targetGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all target groups in an agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobTargetGroup> ListByAgentNext(this IJobTargetGroupsOperations operations, string nextPageLink)
            {
                return operations.ListByAgentNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all target groups in an agent.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobTargetGroup>> ListByAgentNextAsync(this IJobTargetGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAgentNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}