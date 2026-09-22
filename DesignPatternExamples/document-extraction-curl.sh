#!/usr/bin/env bash

set -euo pipefail

BASE_URL="${BASE_URL:-http://127.0.0.1:8000}"
DOCUMENT_PATH="${DOCUMENT_PATH:-/absolute/path/to/document.pdf}"
SCHEMA_JSON="${SCHEMA_JSON:-{\"type\":\"object\",\"properties\":{\"invoiceNumber\":{\"type\":[\"string\",\"null\"]},\"total\":{\"type\":[\"number\",\"null\"]}}}}"
LANGUAGE="${LANGUAGE:-auto}"
OCR_ENGINE="${OCR_ENGINE:-2}"
INCLUDE_LAYOUT_CONTEXT="${INCLUDE_LAYOUT_CONTEXT:-false}"
DETECT_TABLES="${DETECT_TABLES:-false}"
MODEL="${MODEL:-}"

echo "1) Service metadata"
curl --silent --show-error \
  "$BASE_URL/"

echo
echo "2) Health check"
curl --silent --show-error \
  "$BASE_URL/health"

echo
echo "3) Extract document"

if [[ ! -f "$DOCUMENT_PATH" ]]; then
  echo "Set DOCUMENT_PATH to an existing PDF, PNG, or JPEG file before running extraction." >&2
  exit 1
fi

extract_args=(
  --silent
  --show-error
  --request POST
  "$BASE_URL/api/extract"
  --form "file=@${DOCUMENT_PATH}"
  --form "schema=${SCHEMA_JSON}"
  --form "language=${LANGUAGE}"
  --form "ocrEngine=${OCR_ENGINE}"
  --form "includeLayoutContext=${INCLUDE_LAYOUT_CONTEXT}"
  --form "detectTables=${DETECT_TABLES}"
)

if [[ -n "$MODEL" ]]; then
  extract_args+=(--form "model=${MODEL}")
fi

curl "${extract_args[@]}"
echo
