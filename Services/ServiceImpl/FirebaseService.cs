using Firebase.Auth;
using Microsoft.Extensions.Configuration;
using Services.IService;
using System;
using System.IO;
using System.Threading.Tasks;
using Firebase.Storage;
using Microsoft.AspNetCore.Http;


namespace Services.ServiceImpl
{
    public class FirebaseService : IFirebaseService
    {
        private readonly IConfiguration _configuration;
        public FirebaseService(IConfiguration configuration)
        {
            _configuration = configuration;
           
        }

        public async Task<string> Push(IFormFile file, FileStream data)
        {
            var apiKey = _configuration["Firebase:apiKey"];
            var authEmail = _configuration["Firebase:authEmail"];
            var authPassword = _configuration["Firebase:authPassword"];
            var storageBucket = _configuration["Firebase:bucket"];

            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(apiKey));
            var auth = await authProvider.SignInWithEmailAndPasswordAsync(authEmail, authPassword);

            var cancellationToken = new CancellationTokenSource();

            var storage = new FirebaseStorage(
                storageBucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(auth.FirebaseToken),
                    ThrowOnCancel = true
                });

            var task = storage
                .Child("assets")
                .Child($"{file.FileName}.{Path.GetExtension(file.FileName).Substring(1)}")
                .PutAsync(data, cancellationToken.Token);

            try
            {
                var downloadUrl = await task;
                Console.WriteLine($"File uploaded to Firebase Storage. Download URL: {downloadUrl}");
                return downloadUrl;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to upload file to Firebase Storage: {ex.Message}");
                return "";
            }
        }
    }
}
