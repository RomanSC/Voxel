#!/usr/bin/bash

if [$1 = "build"]; then
    echo "Building... "
    mcs -out:./tests/graph_test ./tests/tests.cs ./graph/graph.cs
fi

if [$1 = "run"]; then
    echo "Running ... "
    mcs -out:./tests/graph_test ./tests/tests.cs ./graph/graph.cs && mono ./tests/graph_test
fi
