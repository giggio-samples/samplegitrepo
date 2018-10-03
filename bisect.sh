#!/bin/bash
for filename in ./*.txt; do
  if grep ERR "$filename"; then
    exit 1
  fi
done