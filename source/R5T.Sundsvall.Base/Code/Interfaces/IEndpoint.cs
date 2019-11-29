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
    }
}
