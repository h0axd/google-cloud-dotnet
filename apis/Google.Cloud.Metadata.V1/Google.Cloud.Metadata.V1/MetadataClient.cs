// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Http;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Metadata.V1
{
    /// <summary>
    /// Abstract class providing operations for using metadata for Google Compute Engine.
    /// </summary>
    /// <remarks>
    /// <para>
    /// This abstract class is provided to enable testability while permitting
    /// additional operations to be added in the future. You can construct a <see cref="MetadataClientImpl"/> directly.
    /// </para>
    /// <para>
    /// All instance methods declared in this class are virtual, with an implementation which simply
    /// throws <see cref="NotImplementedException"/>. All these methods are overridden in <see cref="MetadataClientImpl"/>.
    /// </para>
    /// </remarks>
    public abstract class MetadataClient
    {
        /// <summary>The HTTP client which is used to create requests.</summary>
        public virtual ConfigurableHttpClient HttpClient { get { throw new NotImplementedException(); } }

        /// <summary>
        /// Gets a token response which contains an access token to authorize a request synchronously.
        /// </summary>
        /// <exception cref="TokenResponseException">A status code other than success was returned from the server.</exception>
        /// <returns>The token response.</returns>
        public virtual TokenResponse GetAccessToken()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a token response which contains an access token to authorize a request asynchronously.
        /// </summary>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="TokenResponseException">A status code other than success was returned from the server.</exception>
        /// <returns>The token response.</returns>
        public virtual Task<TokenResponse> GetAccessTokenAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the instance's custom metadata value with the specified key synchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Custom metadata are just opaque key/value pairs which allow for custom configuration parameters, scripts, or other
        /// relatively small pieces of data to be associated with the instance.
        /// </para>
        /// <para>
        /// The key must conform to the following regular expression: [a-zA-Z0-9-_]+ and must be less than 128 bytes in length.
        /// </para>
        /// </remarks>
        /// <param name="key">The key of the instance's custom metadata value to get.</param>
        /// <exception cref="ArgumentException">The key is not in the proper format.</exception>
        /// <seealso cref="InstanceMetadata.CustomMetadata"/>
        public virtual string GetCustomInstanceMetadata(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the instance's custom metadata value with the specified key asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Custom metadata are just opaque key/value pairs which allow for custom configuration parameters, scripts, or other
        /// relatively small pieces of data to be associated with the instance.
        /// </para>
        /// <para>
        /// The key must conform to the following regular expression: [a-zA-Z0-9-_]+ and must be less than 128 bytes in length.
        /// </para>
        /// </remarks>
        /// <param name="key">The key of the instance's custom metadata value to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ArgumentException">The key is not in the proper format.</exception>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <seealso cref="InstanceMetadata.CustomMetadata"/>
        public virtual Task<string> GetCustomInstanceMetadataAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the project's custom metadata value with the specified key synchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Custom metadata are just opaque key/value pairs which allow for custom configuration parameters, scripts, or other
        /// relatively small pieces of data to be associated with the project.
        /// </para>
        /// <para>
        /// The key must conform to the following regular expression: [a-zA-Z0-9-_]+ and must be less than 128 bytes in length.
        /// </para>
        /// </remarks>
        /// <param name="key">The key of the project's custom metadata to get.</param>
        /// <exception cref="ArgumentException">The key is not in the proper format.</exception>
        /// <seealso cref="ProjectMetadata.CustomMetadata"/>
        public virtual string GetCustomProjectMetadata(string key)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the project's custom metadata value with the specified key asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Custom metadata are just opaque key/value pairs which allow for custom configuration parameters, scripts, or other
        /// relatively small pieces of data to be associated with the project.
        /// </para>
        /// <para>
        /// The key must conform to the following regular expression: [a-zA-Z0-9-_]+ and must be less than 128 bytes in length.
        /// </para>
        /// </remarks>
        /// <param name="key">The key of the project's custom metadata value to get.</param>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <exception cref="ArgumentException">The key is not in the proper format.</exception>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <seealso cref="ProjectMetadata.CustomMetadata"/>
        public virtual Task<string> GetCustomProjectMetadataAsync(string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the metadata for the VM currently running this code synchronously.
        /// </summary>
        /// <remarks>
        /// The instance metadata contains information about the instance, such as the host name, instance ID, and custom metadata and it can be
        /// accessed without authentication from an application running on the instance. Check <see cref="IsServerAvailable"/> or
        /// <see cref="IsServerAvailableAsync(CancellationToken)"/> to determine if the metadata can be accessed.
        /// </remarks>
        /// <returns>The <see cref="InstanceMetadata"/> representing the metadata.</returns>
        public virtual InstanceMetadata GetInstanceMetadata()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the metadata for the VM currently running this code asynchronously.
        /// </summary>
        /// <remarks>
        /// The instance metadata contains information about the instance, such as the host name, instance ID, and custom metadata and it can be
        /// accessed without authentication from an application running on the instance. Check <see cref="IsServerAvailable"/> or
        /// <see cref="IsServerAvailableAsync(CancellationToken)"/> to determine if the metadata can be accessed.
        /// </remarks>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task containing the <see cref="InstanceMetadata"/> representing the metadata.</returns>
        public virtual Task<InstanceMetadata> GetInstanceMetadataAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the maintenance status for the VM currently running this code synchronously.
        /// </summary>
        /// <remarks>
        /// If the <see cref="InstanceMetadata.Scheduling"/>'s <see cref="SchedulingMetadata.MaintenanceEventBehavior"/> is set to
        /// <see cref="MaintenanceEventBehavior.LiveMigrate"/>, the maintenance status will change to <see cref="MaintenanceStatus.MigrateOnHost"/>
        /// 60 seconds before a maintenance event starts. This will give the application an opportunity to perform any tasks in preparation
        /// for the event, such as backing up data or updating logs. Otherwise, the value will be <see cref="MaintenanceStatus.None"/>.
        /// </remarks>
        /// <returns>The current maintenance status.</returns>
        /// <seealso cref="SchedulingMetadata.MaintenanceEventBehavior"/>
        public virtual MaintenanceStatus GetMaintenanceStatus()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the maintenance status for the VM currently running this code asynchronously.
        /// </summary>
        /// <remarks>
        /// If the <see cref="InstanceMetadata.Scheduling"/>'s <see cref="SchedulingMetadata.MaintenanceEventBehavior"/> is set to
        /// <see cref="MaintenanceEventBehavior.LiveMigrate"/>, the maintenance status will change to <see cref="MaintenanceStatus.MigrateOnHost"/>
        /// 60 seconds before a maintenance event starts. This will give the application an opportunity to perform any tasks in preparation
        /// for the event, such as backing up data or updating logs. Otherwise, the value will be <see cref="MaintenanceStatus.None"/>.
        /// </remarks>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task containing the current maintenance status.</returns>
        /// <seealso cref="SchedulingMetadata.MaintenanceEventBehavior"/>
        public virtual Task<MaintenanceStatus> GetMaintenanceStatusAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the metadata for the project of the VM currently running this code asynchronously.
        /// </summary>
        /// <remarks>
        /// The project metadata contains information about the project, such as its ID, and custom metadata and it can be
        /// accessed without authentication from an application running on an instance of that project. Check <see cref="IsServerAvailable"/> or
        /// <see cref="IsServerAvailableAsync(CancellationToken)"/> to determine if the metadata can be accessed.
        /// </remarks>
        /// <returns>A task containing the <see cref="InstanceMetadata"/> representing the metadata.</returns>
        public virtual ProjectMetadata GetProjectMetadata()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the metadata for the project of the VM currently running this code asynchronously.
        /// </summary>
        /// <remarks>
        /// The project metadata contains information about the project, such as its ID, and custom metadata and it can be
        /// accessed without authentication from an application running on an instance of that project. Check <see cref="IsServerAvailable"/> or
        /// <see cref="IsServerAvailableAsync(CancellationToken)"/> to determine if the metadata can be accessed.
        /// </remarks>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task containing the <see cref="InstanceMetadata"/> representing the metadata.</returns>
        public virtual Task<ProjectMetadata> GetProjectMetadataAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the value indicating whether the metadata server or an emulator for the server is available synchronously.
        /// </summary>
        /// <remarks>
        /// Normally, the metadata server can only be accessed from an application running on a Google Compute Engine VM instance or
        /// Google App Engine Flexible Environment, but if an metadata server emulator is available, this will also return true.
        /// </remarks>
        /// <returns>True if the normal metadata server or an emulator is available; false otherwise.</returns>
        public virtual bool IsServerAvailable()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the value indicating whether the metadata server or an emulator for the server is available asynchronously.
        /// </summary>
        /// <remarks>
        /// Normally, the metadata server can only be accessed from an application running on a Google Compute Engine VM instance or
        /// Google App Engine Flexible Environment, but if an metadata server emulator is available, this will also return true.
        /// </remarks>
        /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
        /// <returns>A task containing true if the normal metadata server or an emulator is available; false otherwise.</returns>
        public virtual Task<bool> IsServerAvailableAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        // TODO: Do we want separate events for when standard and custom metadata changes? Same question for project metadata.
        // TODO: Should we suppress firing these when the custom metadata is updated from here?

        /// <summary>
        /// Occurs when the the instance's metadata has changed.
        /// </summary>
        /// <seealso cref="GetInstanceMetadata"/>
        /// <seealso cref="GetInstanceMetadataAsync"/>
        public virtual event EventHandler InstanceMetadataChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Occurs when the the instance's maintenance status has changed.
        /// </summary>
        /// <seealso cref="GetMaintenanceStatus"/>
        /// <seealso cref="GetMaintenanceStatusAsync(CancellationToken)"/>
        /// <seealso cref="SchedulingMetadata.MaintenanceEventBehavior"/>
        public virtual event EventHandler<MaintenanceStatus> MaintenanceStatusChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Occurs when the the project's metadata has changed.
        /// </summary>
        /// <seealso cref="GetProjectMetadata"/>
        /// <seealso cref="GetProjectMetadataAsync"/>
        public virtual event EventHandler ProjectMetadataChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }
    }
}
