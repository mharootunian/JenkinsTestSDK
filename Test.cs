using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Login;
using Core.TestExecution;

namespace JenkinsTestSuite {
    public class Test : Check {
        public override void BeforeExecute() {
            PxLogin.LogIn();
        }

        public override void Execute() {
            Test1();
        }

        private void Test1() {

        }
    }
}