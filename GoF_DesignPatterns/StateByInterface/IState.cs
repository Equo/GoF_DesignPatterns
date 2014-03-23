using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_DesignPatterns.StateByInterface
{
    /// <summary>
    /// 状態を表すインターフェイス
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// 状態に依存する処理
        /// </summary>
        /// <param name="context">文脈</param>
        void Handle(Context context);
    }
    
    // TODO: 各Stateクラスの生成と破壊のタイミングを決定する。
    // １．必要な時に生成し、その後破壊する。
    // 　　実行時に遷移先状態が分からず、かつ状態遷移回数が少ない場合に向く。
    // ２．事前に生成し、破壊しない。
    // 　　状態遷移が頻繁に起こる場合に向く。Contextクラスが遷移する全ての状態の参照を持つ必要がある。

    /// <summary>
    /// 状態１を表すクラス
    /// </summary>
    public class ConcreteState1 :
        // TODO: 各Stateクラスがローカルな状態を保持しない場合、Singletonパターンが適用できる。
        //GoF_DesignPatterns.Singleton.Singleton,
        IState
    {
        //TODO: Singletonパターンを適用するならば、削除する。
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ConcreteState1()
        {
            ;
        }

        /// <summary>
        /// 状態１での処理の実装
        /// </summary>
        /// <param name="context">文脈</param>
        public void Handle(Context context)
        {
            ;
        }
    }

    /// <summary>
    /// 状態２を表すクラス
    /// </summary>
    public class ConcreteState2 :
        // TODO: 各Stateクラスがローカルな状態を保持しない場合、Singletonパターンが適用できる。
        //GoF_DesignPatterns.Singleton.Singleton,
        IState
    {
        //TODO: Singletonパターンを適用するならば、削除する。
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ConcreteState2()
        {
            ;
        }

        /// <summary>
        /// 状態２での処理の実装
        /// </summary>
        /// <param name="context">文脈</param>
        public void Handle(Context context)
        {
            ;
        }
    }
}
