﻿using System.Linq;
using DynamicExpresso;
using Microsoft.Extensions.DependencyInjection;

namespace BotNet.Services.DynamicExpresso {
	public static class ServiceCollectionExtensions {
		public static IServiceCollection AddCSharpEvaluator(this IServiceCollection services) {
			services.AddSingleton(new Interpreter(options: InterpreterOptions.Default | InterpreterOptions.LambdaExpressions)
				.Reference(
					from type in new[] {
						typeof(System.Array),
						typeof(System.ArraySegment<>),
						typeof(System.BitConverter),
						typeof(System.Buffer),
						typeof(System.Convert),
						typeof(System.Converter<,>),
						typeof(System.DateOnly),
						typeof(System.DateTimeOffset),
						typeof(System.Exception),
						typeof(System.Half),
						typeof(System.HashCode),
						typeof(System.Index),
						typeof(System.IntPtr),
						typeof(System.MathF),
						typeof(System.Memory<>),
						typeof(System.Nullable),
						typeof(System.Nullable<>),
						typeof(System.OperatingSystem),
						typeof(System.PlatformID),
						typeof(System.Random),
						typeof(System.Range),
						typeof(System.ReadOnlyMemory<>),
						typeof(System.ReadOnlySpan<>),
						typeof(System.SequencePosition),
						typeof(System.Span<>),
						typeof(System.StringComparer),
						typeof(System.StringComparison),
						typeof(System.StringSplitOptions),
						typeof(System.TimeOnly),
						typeof(System.TimeZoneInfo),
						typeof(System.Tuple),
						typeof(System.Tuple<>),
						typeof(System.TypeCode),
						typeof(System.Uri),
						typeof(System.UriBuilder),
						typeof(System.UriComponents),
						typeof(System.UriCreationOptions),
						typeof(System.UriFormat),
						typeof(System.UriHostNameType),
						typeof(System.UriKind),
						typeof(System.UriParser),
						typeof(System.UriPartial),
						typeof(System.UriTypeConverter),
						typeof(System.ValueTuple),
						typeof(System.ValueTuple<>),
						typeof(System.ValueType),
						typeof(System.Version),
					}
					select new ReferenceType(type)
				)
			);
			services.AddTransient<CSharpEvaluator>();
			return services;
		}
	}
}
