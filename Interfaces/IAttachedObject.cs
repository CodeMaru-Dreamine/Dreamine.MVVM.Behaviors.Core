using System.Windows;

namespace Dreamine.MVVM.Behaviors.Core.Interfaces
{
	/// <summary>
	/// \if KO
	/// <para>📌 Dreamine의 모든 Behavior는 이 인터페이스를 통해 연결 객체를 관리합니다. FrameworkElement 또는 DependencyObject와 연결되는 객체의 공통 인터페이스로, Behavior 및 트리거 확장 구현 시 연결 대상의 참조를 일관되게 제공합니다.</para>
	/// \endif
	/// \if EN
	/// <para>Encapsulates i attached object functionality and related state.</para>
	/// \endif
	/// </summary>
	public interface IAttachedObject
	{
		/// <summary>
		/// \if KO
		/// <para>연결된 객체 (DependencyObject)를 반환합니다.</para>
		/// \endif
		/// \if EN
		/// <para>Gets the associated object value.</para>
		/// \endif
		/// </summary>
		DependencyObject AssociatedObject { get; }

		/// <summary>
		/// \if KO
		/// <para>지정된 DependencyObject에 현재 객체를 연결합니다.</para>
		/// \endif
		/// \if EN
		/// <para>Attaches the behavior to a target object.</para>
		/// \endif
		/// </summary>
		/// <param name="dependencyObject">
		/// \if KO
		/// <para>연결할 대상 객체입니다.</para>
		/// \endif
		/// \if EN
		/// <para>The dependency object to which the behavior or attached property applies.</para>
		/// \endif
		/// </param>
		void Attach(DependencyObject dependencyObject);

		/// <summary>
		/// \if KO
		/// <para>현재 객체를 연결된 대상에서 분리합니다.</para>
		/// \endif
		/// \if EN
		/// <para>Detaches the behavior from its current target object.</para>
		/// \endif
		/// </summary>
		void Detach();
	}	
}
