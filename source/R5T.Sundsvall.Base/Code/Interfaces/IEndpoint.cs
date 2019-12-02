using System;

using R5T.Sindia;


namespace R5T.Sundsvall
{
    public interface IEndpoint
    {
        /// <summary>
        /// Sends an anomaly to the endpoint.
        /// </summary>
        void Send(AnomalyIdentity anomaly);

        /// <summary>
        /// Used in debugging, or to exactly specify the message to send to an endpoint.
        /// </summary>
        void Send(string message);
    }
}
