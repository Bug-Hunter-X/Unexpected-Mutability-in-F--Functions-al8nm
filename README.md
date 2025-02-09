# Unexpected Mutable Variable Behavior in F#

This repository demonstrates a subtle bug related to mutable variables in F#.  The `addOne` function modifies a mutable variable passed as an argument. The consequence is that calling the function multiple times leads to seemingly unexpected changes to the original variable's value.

The `bug.fs` file shows the problematic code.  The `bugSolution.fs` file demonstrates how to resolve this by avoiding mutable variables or creating a copy to avoid unintended side effects.

## How to Reproduce

1. Clone this repository.
2. Open `bug.fs` in an F# editor.
3. Run the code. Observe the output.
4. Compare the output to the corrected code in `bugSolution.fs` to understand the difference in behavior.