﻿using System.Collections;

namespace Shiroi.Cutscenes.Tokens {
    public class ExecuteCutsceneToken : Token {
        public Cutscene Cutscene;

        public override IEnumerator Execute(CutsceneExecutor executor) {
            yield break;
        }
    }
}