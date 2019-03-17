using System;

namespace DesignPatterns.ChainofResponsibility
{
    public interface IAuthenticationProvider
    {
        
    }
        
    public abstract class AuthenticationProcessor
    {
        public AuthenticationProcessor NextProcessor { get; }

        public AuthenticationProcessor(AuthenticationProcessor nextProcessor)
        {
            NextProcessor = nextProcessor;
        }
        
        public abstract bool Handle(IAuthenticationProvider provider);
    }

    public class OAuthProcessor : AuthenticationProcessor
    {
        public OAuthProcessor(AuthenticationProcessor nextProcessor) : base(nextProcessor)
        {
        }
        
        public override bool Handle(IAuthenticationProvider provider)
        {
            if (provider == null)
            {
                throw new ArgumentException("provider not be null");
            }
            
            if (!(provider is OAuthTokenProvider))
            {
                throw new Exception("Unsupported provider");
            }

            Console.WriteLine("Authenticated with OAuth");
            return true;
        }
    }

    public class OAuthTokenProvider : IAuthenticationProvider
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class SamlProcessor : AuthenticationProcessor
    {
        public SamlProcessor(AuthenticationProcessor nextProcessor) : base(nextProcessor)
        {
        }
        
        public override bool Handle(IAuthenticationProvider provider)
        {
            if (provider == null)
            {
                throw new ArgumentException("provider not be null");
            }
            
            if (!(provider is SamlTokenProvider))
            {
                throw new Exception("Unsupported provider");
            }

            Console.WriteLine("Authenticated with SAML");
            return true;
        }
    }

    public class SamlTokenProvider : IAuthenticationProvider
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            AuthenticationProcessor oAuthProcessor = new OAuthProcessor(null);
            oAuthProcessor.Handle(new OAuthTokenProvider());
            
            AuthenticationProcessor samlProcessor = new SamlProcessor(oAuthProcessor);
            samlProcessor.Handle(new SamlTokenProvider());
        }
    }
}