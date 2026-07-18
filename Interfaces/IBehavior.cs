using System.Windows;

namespace Dreamine.MVVM.Behaviors.Core.Interfaces
{
	/// <summary>
	/// \if KO
	/// <para>📌 Dreamine에서 모든 Behavior가 구현해야 하는 핵심 인터페이스입니다. - View 요소(DependencyObject)에 연결/분리되는 확장 동작을 정의합니다. - XAML 또는 코드에서 동적으로 attach 가능한 구조 기반입니다.</para>
	/// \endif
	/// \if EN
	/// <para>Encapsulates i behavior functionality and related state.</para>
	/// \endif
	/// </summary>
	public interface IBehavior : IAttachedObject
	{
	}
}
