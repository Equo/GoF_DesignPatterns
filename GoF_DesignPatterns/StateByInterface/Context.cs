using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_DesignPatterns.StateByInterface
{
    /// <summary>
    /// Stateパターンの文脈
    /// </summary>
    public class Context
    {
        // TODO: 状態遷移に責任を持つオブジェクトを決定する。
        // １．Contextクラス内に全てのルールを記述する。
        // ２．各Stateクラスに遷移時期と遷移後の状態を記述する。
        // 　　この場合、Contextクラスは、状態更新のインターフェイスを持つ必要がある。
        // 　　この場合、各Stateクラスは遷移後のクラスを知っていなければならない。
        /// <summary>
        /// 状態
        /// </summary>
        private IState state;

        /// <summary>
        /// 状態を取得、設定する。
        /// </summary>
        public IState State
        {
            get { return state; }
            private set { state = value; }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="state">初期状態</param>
        public Context(IState state)
        {
            State = state;
        }

        /// <summary>
        /// 状態に依存する処理のインターフェース
        /// </summary>
        public void Request()
        {
            State.Handle(this);
        }
    }
}
