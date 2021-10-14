pipeline {
  agent any
  stages {
    stage('build') {
      steps {
        bat 'dotnet build'
        bat 'net stop W3svc'
      }
    }

    stage('deploy') {
      steps {
        bat 'dotnet publish'
      }
    }

    stage('restart iis') {
      steps {
        bat 'iisreset'
      }
    }

    stage('start iis') {
      steps {
        bat 'net start W3svc'
      }
    }

    stage('stop iis') {
      steps {
        bat 'net stop W3svc'
      }
    }

  }
}