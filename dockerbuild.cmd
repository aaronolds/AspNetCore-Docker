docker build -t mydemo:aspdotnet .
docker rm -f mydemo
docker run -d -p 8080:5000 --name mydemo  -t mydemo:aspdotnet