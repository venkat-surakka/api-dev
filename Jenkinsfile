pipeline {
  agent any
  stages {
    stage('stop iis') {
      steps {
        bat 'net stop W3svc'
      }
    }

    stage('build') {
      steps {
        bat 'dotnet build'
      }
    }

    stage('publish') {
      steps {
        bat 'dotnet publish'
      }
    }

    stage('start iis') {
      steps {
        bat 'net start W3svc'
      }
    }
  }
}