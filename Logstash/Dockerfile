FROM docker.elastic.co/logstash/logstash-oss:8.0.0

EXPOSE 9000/udp

RUN rm -f /usr/share/logstash/pipeline/*

COPY Logstash/main-pipeline.conf /usr/share/logstash/pipeline/
COPY Logstash/logstash.yml /usr/share/logstash/config/logstash.yml