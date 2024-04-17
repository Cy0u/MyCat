using System;
using Microsoft.Extensions.DependencyInjection;
using MyCat.ViewModels;

namespace MyCat;

public class ServicesRegistration
{
  public static IServiceProvider? ServiceProvider { get; private set; }

  public static void Register(IServiceCollection services)
  {
    services.AddSingleton<MainViewModel>();
    ServiceProvider = services.BuildServiceProvider();
  }
  
  public static T Resolve<T>() => ServiceProvider.GetService<T>();

}