using AirKG.Entity;
using AirKG.Enum;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace AirKG.Context
{
    public static class DbInitializer
    {
        public static async Task Seed(this AirKGDbContext context)
        {
            var dte = new DateTime(2022, 06, 13, 21, 40, 21);
            var dteSencor = new DateTime(2023, 03, 10, 11, 11, 11);
            if (!context.Districts.Any())
            {
                var disrict1 = new District()
                {
                    Name = "Ленинский",
                    SensorQuantity = 3,
                    Sensors = new List<Sensor>()
                    {
                        new Sensor()
                        {
                            PlaceName = "Омуракунова/Сыдыкова",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 520,
                            Latitude = 970,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 86,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 8
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 73,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 9
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 50,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 12.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 12,
                                    DegreeOfQuality = AirDegreeOfQuality.Good,
                                    Temperature = 17.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 32,
                                    DegreeOfQuality = AirDegreeOfQuality.Moderate,
                                    Temperature = 22.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 96,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 20.5
                                }
                            }
                        },
                        new Sensor()
                        {
                            PlaceName = "Чертекова/Куюкова",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 680,
                            Latitude = 880,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 80,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 6.3
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 72,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 11
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 43,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 12.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 10,
                                    DegreeOfQuality = AirDegreeOfQuality.Good,
                                    Temperature = 18.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 33,
                                    DegreeOfQuality = AirDegreeOfQuality.Moderate,
                                    Temperature = 21.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 103,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 19.5
                                }
                            }
                        },
                        new Sensor()
                        {
                            PlaceName = "Сыдырбава/Бирдибаева",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 780,
                            Latitude = 870,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 76,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 8.3
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 68,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 9
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 39,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 13.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 14,
                                    DegreeOfQuality = AirDegreeOfQuality.Good,
                                    Temperature = 17.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 31,
                                    DegreeOfQuality = AirDegreeOfQuality.Moderate,
                                    Temperature = 23.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 89,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 17.5
                                }
                            }
                        },
                    }
                };
                var district2 = new District()
                {
                    Name = "Октябрьский",
                    SensorQuantity = 4,
                    Sensors = new List<Sensor>()
                    {
                        new Sensor()
                        {
                            PlaceName = "Омуракунова/Сыдыкова",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 610,
                            Latitude = 790,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 84,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 5.1
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 64,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 10.7
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 28,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 13.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 23,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 17.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 35,
                                    DegreeOfQuality = AirDegreeOfQuality.Moderate,
                                    Temperature = 21.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 101,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 12.5
                                }
                            }
                        },
                        new Sensor()
                        {
                            PlaceName = "Чертекова/Куюкова",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 700,
                            Latitude = 840,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 75,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 7.1
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 69,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 12.7
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 30,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 13.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 27,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 13.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 37,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 19.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 111,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 14.5
                                }
                            }
                        },
                        new Sensor()
                        {
                            PlaceName = "Сыдырбава/Бирдибаева",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 690,
                            Latitude = 970,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 66,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 7.1
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 68,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 10.7
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 23,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 13.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 21,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 13.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 47,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 19.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 89,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 14.5
                                }
                            }
                        },
                    }
                };
                var district3 = new District()
                {
                    Name = "Первомайский",
                    SensorQuantity = 4,
                    Sensors = new List<Sensor>()
                    {
                        new Sensor()
                        {
                            PlaceName = "Максима Горького/Панфилова",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 590,
                            Latitude = 1050,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 89,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 6.1
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 67,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 9.7
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 28,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 13.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 21,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 19.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 35,
                                    DegreeOfQuality = AirDegreeOfQuality.Moderate,
                                    Temperature = 21.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 91,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 12.5
                                }
                            }
                        },
                        new Sensor()
                        {
                            PlaceName = "Московская/Панфилова",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 530,
                            Latitude = 1050,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 75,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 8.1
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 69,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 18.7
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 30,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 13.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 27,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 11.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 37,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 18.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 111,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 11.5
                                }
                            }
                        },
                        new Sensor()
                        {
                            PlaceName = "Профсоюзная/Бородина",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 410,
                            Latitude = 840,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 96,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 8.1
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 61,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 11.7
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 19,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 14.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 23,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 16.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 55,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 14.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 91,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 12.5
                                }
                            }
                        },
                    }
                };
                var district4 = new District()
                {
                    Name = "Свердловский",
                    SensorQuantity = 4,
                    Sensors = new List<Sensor>()
                    {
                        new Sensor()
                        {
                            PlaceName = "Чуй/7 апреля",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 430,
                            Latitude = 1100,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 110,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 5.1
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 67,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 8.7
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 28,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 10.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 21,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 17.6
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 33,
                                    DegreeOfQuality = AirDegreeOfQuality.Moderate,
                                    Temperature = 20.1
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 95,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 12.5
                                }
                            }
                        },
                        new Sensor()
                        {
                            PlaceName = "Сельская/Путепроводная",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 500,
                            Latitude = 1310,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 80,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 6.1
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 85,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 16.7
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 27,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 12.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 12,
                                    DegreeOfQuality = AirDegreeOfQuality.Good,
                                    Temperature = 14.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 37,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 17.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 96,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 10.5
                                }
                            }
                        },
                        new Sensor()
                        {
                            PlaceName = "Елебесова/Куренкеева",
                            IsWork = true,
                            ReplacementDate = dteSencor,
                            Longitude = 340,
                            Latitude = 1000,
                            AirDatas = new List<AirData>()
                            {
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 03, 00, 00),
                                    AirQuality = 96,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 6.7
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 06, 00, 00),
                                    AirQuality = 66,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 12
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 09, 00, 00),
                                    AirQuality = 23,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 14.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 12, 00, 00),
                                    AirQuality = 33,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 16.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 15, 00, 00),
                                    AirQuality = 53,
                                    DegreeOfQuality = AirDegreeOfQuality.Unhealthy,
                                    Temperature = 14.5
                                },
                                new AirData {
                                    DateCreate = new DateTime(2023, 03, 10, 18, 00, 00),
                                    AirQuality = 85,
                                    DegreeOfQuality = AirDegreeOfQuality.VeryUnhealthy,
                                    Temperature = 12.5
                                }
                            }
                        },
                    }
                };
                context.Districts.Add(disrict1); 
                context.Districts.Add(district2);
                context.Districts.Add(district3);
                context.Districts.Add(district4);
                await context.SaveChangesAsync();

            }
        }
    }
}